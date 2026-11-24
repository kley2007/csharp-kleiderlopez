using Microsoft.EntityFrameworkCore;

namespace Reto;

public partial class Form1 : Form
{
    private int? _idEditando;

    public Form1()
    {
        InitializeComponent();
        CargarContactos();
    }

    private void CargarContactos(string filtro = "")
    {
        using var db = new AgendaContext();

        dgvContactos.DataSource = db.Contactos
            .AsNoTracking()
            .Where(c => EF.Functions.Like(c.Nombre, $"%{filtro}%"))
            .OrderBy(c => c.Nombre)
            .ToList();

        lblTotal.Text = $"{dgvContactos.Rows.Count} contactos";
    }

    private void txtBuscar_TextChanged(object? sender, EventArgs e)
        => CargarContactos(txtBuscar.Text.Trim());

    private void btnAgregar_Click(object? sender, EventArgs e)
    {
        errorProvider1.Clear();

        bool valido = true;
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains('@'))
        {
            errorProvider1.SetError(txtCorreo, "Escribe un correo válido que contenga @.");
            valido = false;
        }

        if (!valido) return;

        using var db = new AgendaContext();
        db.Contactos.Add(new Contacto
        {
            Nombre = txtNombre.Text.Trim(),
            Telefono = txtTelefono.Text.Trim(),
            Correo = txtCorreo.Text.Trim()
        });
        db.SaveChanges();

        LimpiarFormulario();
        CargarContactos(txtBuscar.Text.Trim());
        MessageBox.Show("Contacto agregado correctamente.", "Agenda",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (dgvContactos.CurrentRow?.DataBoundItem is not Contacto contacto)
            return;

        var respuesta = MessageBox.Show(
            $"¿Eliminar a {contacto.Nombre}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (respuesta != DialogResult.Yes) return;

        using var db = new AgendaContext();
        var existente = db.Contactos.Find(contacto.Id);
        if (existente is not null)
        {
            db.Contactos.Remove(existente);
            db.SaveChanges();
        }

        CargarContactos(txtBuscar.Text.Trim());
    }

    private void dgvContactos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 ||
            dgvContactos.Rows[e.RowIndex].DataBoundItem is not Contacto contacto)
            return;

        _idEditando = contacto.Id;
        txtNombre.Text = contacto.Nombre;
        txtTelefono.Text = contacto.Telefono;
        txtCorreo.Text = contacto.Correo;
        btnAgregar.Enabled = false;
        btnGuardarCambios.Enabled = true;
        btnCancelarEdicion.Enabled = true;
        lblModo.Text = $"Editando contacto #{contacto.Id}";
    }

    private void btnGuardarCambios_Click(object? sender, EventArgs e)
    {
        errorProvider1.Clear();
        if (_idEditando is null) return;

        bool valido = true;
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
            valido = false;
        }
        if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains('@'))
        {
            errorProvider1.SetError(txtCorreo, "Escribe un correo válido que contenga @.");
            valido = false;
        }
        if (!valido) return;

        using var db = new AgendaContext();
        var contacto = db.Contactos.Find(_idEditando.Value);
        if (contacto is null)
        {
            MessageBox.Show("El contacto ya no existe.", "Agenda",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LimpiarFormulario();
            CargarContactos(txtBuscar.Text.Trim());
            return;
        }

        contacto.Nombre = txtNombre.Text.Trim();
        contacto.Telefono = txtTelefono.Text.Trim();
        contacto.Correo = txtCorreo.Text.Trim();
        db.SaveChanges();

        LimpiarFormulario();
        CargarContactos(txtBuscar.Text.Trim());
        MessageBox.Show("Cambios guardados.", "Agenda",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnCancelarEdicion_Click(object? sender, EventArgs e)
        => LimpiarFormulario();

    private void btnLimpiar_Click(object? sender, EventArgs e)
        => LimpiarFormulario();

    private void LimpiarFormulario()
    {
        _idEditando = null;
        txtNombre.Clear();
        txtTelefono.Clear();
        txtCorreo.Clear();
        errorProvider1.Clear();
        btnAgregar.Enabled = true;
        btnGuardarCambios.Enabled = false;
        btnCancelarEdicion.Enabled = false;
        lblModo.Text = "Nuevo contacto";
    }
}
