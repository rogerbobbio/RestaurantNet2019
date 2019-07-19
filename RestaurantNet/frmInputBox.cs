using System.Windows.Forms;
using System.Drawing;
using System;


namespace RestaurantNet
{
  public sealed class frmInputBox
  {
    public static DialogResult InputBox(string title, string promptText, string tableName, string fieldName,  string fieldRef, ref string value, bool validateKey, bool showDialog)
    {
      DialogResult dialogResult = DialogResult.OK;
      if (showDialog)
      {
        Form form = new Form();
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button buttonOk = new Button();
        Button buttonCancel = new Button();

        form.Text = title;
        label.Text = promptText;
        if (validateKey)
          textBox.PasswordChar = '*';
        textBox.Text = value;

        buttonOk.Text = "OK";
        buttonCancel.Text = "Cancel";
        buttonOk.DialogResult = DialogResult.OK;
        buttonCancel.DialogResult = DialogResult.Cancel;

        label.SetBounds(9, 20, 372, 13);
        textBox.SetBounds(12, 36, 372, 20);
        textBox.CharacterCasing = CharacterCasing.Upper;
        buttonOk.SetBounds(228, 72, 75, 23);
        buttonCancel.SetBounds(309, 72, 75, 23);

        label.AutoSize = true;
        textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
        buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        form.ClientSize = new Size(396, 107);
        form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
        form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.MinimizeBox = false;
        form.MaximizeBox = false;
        form.AcceptButton = buttonOk;
        form.CancelButton = buttonCancel;

        dialogResult = form.ShowDialog();
        value = textBox.Text.Trim();

        if (validateKey)
        {
          if (value != string.Empty)
          {
            string sWhere = "codigo_empleado = " + fieldRef + " AND " + fieldName + " = '" + value + "'";
            if (DataUtil.FindSingleRow(tableName, fieldName, sWhere) == string.Empty)
            {
              MessageBox.Show("El password es incorrecto.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              dialogResult = DialogResult.Cancel;
            }
          }
          else
            dialogResult = DialogResult.Cancel;
        }
        else
        {
          if (value != string.Empty)
          {
            string sWhere = fieldName + " = '" + value + "'";
            if (DataUtil.FindSingleRow(tableName, fieldName, sWhere) != string.Empty)
              MessageBox.Show("El registro ya existe en la base de datos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
              try
              {
                string sqlInsert = string.Empty;
                if (tableName.Equals("cliente_email"))
                {
                  sqlInsert = "INSERT INTO " + tableName + " (" +
                               fieldName + "," +
                               "cliente_id)" +
                               " VALUES (" +
                               "'" + DataUtil.GetString(value) + "'," +
                               fieldRef + ")";
                }
                else
                {
                  sqlInsert = "INSERT INTO " + tableName + " (" +
                               fieldName + ")" +
                               " VALUES (" +
                               "'" + DataUtil.GetString(value) + "')";
                }
                if (DataUtil.Update(sqlInsert))
                  MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              catch (Exception ex)
              {
                MessageBox.Show("Error en Grabar: " + ex.Message);
              }
            }
          }
          else
            dialogResult = DialogResult.Cancel;
        }
      }        
      return dialogResult;
    }

  }
}
