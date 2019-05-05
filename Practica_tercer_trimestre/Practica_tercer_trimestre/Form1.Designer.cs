namespace Practica_tercer_trimestre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resgistarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todasLasVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porArticuloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porTodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porUnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTodoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaEntreDosFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaTotalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaEntreDosFechasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGeneralToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGeneralToolStripMenuItem
            // 
            this.menuGeneralToolStripMenuItem.Name = "menuGeneralToolStripMenuItem";
            this.menuGeneralToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.menuGeneralToolStripMenuItem.Text = "Menu general";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasToolStripMenuItem,
            this.porProveedorToolStripMenuItem,
            this.porFechaToolStripMenuItem,
            this.porArticuloToolStripMenuItem,
            this.porTodoToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // todasToolStripMenuItem
            // 
            this.todasToolStripMenuItem.Name = "todasToolStripMenuItem";
            this.todasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.todasToolStripMenuItem.Text = "Todas";
            this.todasToolStripMenuItem.Click += new System.EventHandler(this.todasToolStripMenuItem_Click);
            // 
            // porProveedorToolStripMenuItem
            // 
            this.porProveedorToolStripMenuItem.Name = "porProveedorToolStripMenuItem";
            this.porProveedorToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.porProveedorToolStripMenuItem.Text = "Por proveedor";
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.porFechaToolStripMenuItem.Text = "Por fecha";
            // 
            // porArticuloToolStripMenuItem
            // 
            this.porArticuloToolStripMenuItem.Name = "porArticuloToolStripMenuItem";
            this.porArticuloToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.porArticuloToolStripMenuItem.Text = "Por articulo";
            // 
            // porTodoToolStripMenuItem
            // 
            this.porTodoToolStripMenuItem.Name = "porTodoToolStripMenuItem";
            this.porTodoToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.porTodoToolStripMenuItem.Text = "Por todo";
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resgistarToolStripMenuItem,
            this.consultarToolStripMenuItem1,
            this.borrarToolStripMenuItem1});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // resgistarToolStripMenuItem
            // 
            this.resgistarToolStripMenuItem.Name = "resgistarToolStripMenuItem";
            this.resgistarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.resgistarToolStripMenuItem.Text = "Resgistar";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasLasVentasToolStripMenuItem,
            this.porClienteToolStripMenuItem,
            this.porFechaToolStripMenuItem1,
            this.porArticuloToolStripMenuItem1,
            this.porTodoToolStripMenuItem1});
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // todasLasVentasToolStripMenuItem
            // 
            this.todasLasVentasToolStripMenuItem.Name = "todasLasVentasToolStripMenuItem";
            this.todasLasVentasToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.todasLasVentasToolStripMenuItem.Text = "Todas las ventas";
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.porClienteToolStripMenuItem.Text = "Por cliente";
            // 
            // porFechaToolStripMenuItem1
            // 
            this.porFechaToolStripMenuItem1.Name = "porFechaToolStripMenuItem1";
            this.porFechaToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.porFechaToolStripMenuItem1.Text = "Por fecha";
            // 
            // porArticuloToolStripMenuItem1
            // 
            this.porArticuloToolStripMenuItem1.Name = "porArticuloToolStripMenuItem1";
            this.porArticuloToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.porArticuloToolStripMenuItem1.Text = "Por articulo";
            // 
            // porTodoToolStripMenuItem1
            // 
            this.porTodoToolStripMenuItem1.Name = "porTodoToolStripMenuItem1";
            this.porTodoToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.porTodoToolStripMenuItem1.Text = "Por todo";
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirArticuloToolStripMenuItem,
            this.consultarArticuloToolStripMenuItem,
            this.borrarArticuloToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // añadirArticuloToolStripMenuItem
            // 
            this.añadirArticuloToolStripMenuItem.Name = "añadirArticuloToolStripMenuItem";
            this.añadirArticuloToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.añadirArticuloToolStripMenuItem.Text = "Añadir articulo";
            // 
            // consultarArticuloToolStripMenuItem
            // 
            this.consultarArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosDatosToolStripMenuItem,
            this.porNombreToolStripMenuItem,
            this.porUnidadesToolStripMenuItem,
            this.porPrecioToolStripMenuItem,
            this.porTodoToolStripMenuItem2});
            this.consultarArticuloToolStripMenuItem.Name = "consultarArticuloToolStripMenuItem";
            this.consultarArticuloToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.consultarArticuloToolStripMenuItem.Text = "Consultar articulo";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.todosLosDatosToolStripMenuItem.Text = "Todos los datos";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.porNombreToolStripMenuItem.Text = "Por nombre";
            // 
            // porUnidadesToolStripMenuItem
            // 
            this.porUnidadesToolStripMenuItem.Name = "porUnidadesToolStripMenuItem";
            this.porUnidadesToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.porUnidadesToolStripMenuItem.Text = "Por unidades";
            // 
            // porPrecioToolStripMenuItem
            // 
            this.porPrecioToolStripMenuItem.Name = "porPrecioToolStripMenuItem";
            this.porPrecioToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.porPrecioToolStripMenuItem.Text = "Por precio";
            // 
            // porTodoToolStripMenuItem2
            // 
            this.porTodoToolStripMenuItem2.Name = "porTodoToolStripMenuItem2";
            this.porTodoToolStripMenuItem2.Size = new System.Drawing.Size(188, 26);
            this.porTodoToolStripMenuItem2.Text = "Por todo";
            // 
            // borrarArticuloToolStripMenuItem
            // 
            this.borrarArticuloToolStripMenuItem.Name = "borrarArticuloToolStripMenuItem";
            this.borrarArticuloToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.borrarArticuloToolStripMenuItem.Text = "Borrar articulo";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem1,
            this.ventasToolStripMenuItem1,
            this.stockToolStripMenuItem1});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaTotalToolStripMenuItem,
            this.mediaEntreDosFechasToolStripMenuItem});
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.comprasToolStripMenuItem1.Text = "Compras";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaTotalToolStripMenuItem1,
            this.mediaEntreDosFechasToolStripMenuItem1});
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // stockToolStripMenuItem1
            // 
            this.stockToolStripMenuItem1.Name = "stockToolStripMenuItem1";
            this.stockToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.stockToolStripMenuItem1.Text = "Stock";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.creditosToolStripMenuItem.Text = "Creditos";
            // 
            // mediaTotalToolStripMenuItem
            // 
            this.mediaTotalToolStripMenuItem.Name = "mediaTotalToolStripMenuItem";
            this.mediaTotalToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.mediaTotalToolStripMenuItem.Text = "Media total";
            // 
            // mediaEntreDosFechasToolStripMenuItem
            // 
            this.mediaEntreDosFechasToolStripMenuItem.Name = "mediaEntreDosFechasToolStripMenuItem";
            this.mediaEntreDosFechasToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.mediaEntreDosFechasToolStripMenuItem.Text = "Media entre dos fechas";
            // 
            // mediaTotalToolStripMenuItem1
            // 
            this.mediaTotalToolStripMenuItem1.Name = "mediaTotalToolStripMenuItem1";
            this.mediaTotalToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.mediaTotalToolStripMenuItem1.Text = "Media total";
            // 
            // mediaEntreDosFechasToolStripMenuItem1
            // 
            this.mediaEntreDosFechasToolStripMenuItem1.Name = "mediaEntreDosFechasToolStripMenuItem1";
            this.mediaEntreDosFechasToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.mediaEntreDosFechasToolStripMenuItem1.Text = "Media entre dos fechas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 253);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resgistarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todasLasVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porArticuloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porTodoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porUnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTodoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem borrarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaEntreDosFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaTotalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mediaEntreDosFechasToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

