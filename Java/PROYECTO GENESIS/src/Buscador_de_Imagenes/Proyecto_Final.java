/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Buscador_de_Imagenes;

import java.util.HashMap;
import javax.swing.DefaultListModel;
import javax.swing.ImageIcon;

/**
 *
 * @author Tomás, Zulay y Martha.
 */
public class Proyecto_Final extends javax.swing.JFrame {

    DefaultListModel modeloAnimales = new DefaultListModel();
    HashMap<String, String> coleccion1 = new HashMap<String, String>();
    //--------------------------------------------------------------------
    DefaultListModel modeloAutos = new DefaultListModel();
    HashMap<String, String> coleccion2 = new HashMap<String, String>();
    //--------------------------------------------------------------------
    DefaultListModel modeloPaisaje = new DefaultListModel();
    HashMap<String, String> coleccion3 = new HashMap<String, String>();
    //--------------------------------------------------------------------
    DefaultListModel modeloAnime = new DefaultListModel();
    HashMap<String, String> coleccion4 = new HashMap<String, String>();
    //--------------------------------------------------------------------
    DefaultListModel modeloCaricatura = new DefaultListModel();
    HashMap<String, String> coleccion5 = new HashMap<String, String>();
    //--------------------------------------------------------------------
    DefaultListModel modeloLeagueOfLegends = new DefaultListModel();
    HashMap<String, String> coleccion6 = new HashMap<String, String>();

    /**
     * Creates new form Test
     */
    public Proyecto_Final() {
        super("Buscador de Imagenes");
        initComponents();
        this.setLocationRelativeTo(this);

        ListAnimales.setModel(modeloAnimales);
        coleccion1.put("Caballo Dorado", "src/Buscador_de_Imagenes/CABALLO.jpeg");
        coleccion1.put("Aguila", "src/Buscador_de_Imagenes/AGUILA.jpeg");
        coleccion1.put("Caballo Albino", "src/Buscador_de_Imagenes/ALBINO.jpeg");
        coleccion1.put("Cocker", "src/Buscador_de_Imagenes/COCKER.jpeg");
        coleccion1.put("Grandanes", "src/Buscador_de_Imagenes/GRANDANES.jpeg");
        for (Object x : coleccion1.keySet()) {
            modeloAnimales.addElement(String.valueOf(x));
        }
        //---------------------------------------------------------------------
        ListAutos.setModel(modeloAutos);
        coleccion2.put("Mustang", "src/Buscador_de_Imagenes/MUSTANG.jpeg");
        coleccion2.put("Camaro", "src/Buscador_de_Imagenes/CAMARO.jpg");
        coleccion2.put("Dodge", "src/Buscador_de_Imagenes/DODGE.jpeg");
        coleccion2.put("Ferrari", "src/Buscador_de_Imagenes/FERRARI.jpeg");
        coleccion2.put("Mercedes Benz", "src/Buscador_de_Imagenes/MERCEDES BENZ.jpeg");
        for (Object x : coleccion2.keySet()) {
            modeloAutos.addElement(String.valueOf(x));
        }
        //---------------------------------------------------------------------
        ListPaisajes.setModel(modeloPaisaje);
        coleccion3.put("Playa", "src/Buscador_de_Imagenes/PLAYA.jpeg");
        coleccion3.put("Nieve", "src/Buscador_de_Imagenes/NIEVE.jpg");
        coleccion3.put("Cascada", "src/Buscador_de_Imagenes/CASCADA.jpeg");
        coleccion3.put("Cerro", "src/Buscador_de_Imagenes/CERRO.jpeg");
        coleccion3.put("Luna Morada", "src/Buscador_de_Imagenes/LUNA MORADA.jpeg");
        for (Object x : coleccion3.keySet()) {
            modeloPaisaje.addElement(String.valueOf(x));
        }
        //---------------------------------------------------------------------
        ListAnime.setModel(modeloAnime);
        coleccion4.put("Sword Art Online", "src/Buscador_de_Imagenes/SWORD ART ONLINE.jpg");
        coleccion4.put("Nekopara", "src/Buscador_de_Imagenes/NEKOPARA.jpg");
        coleccion4.put("Castillo", "src/Buscador_de_Imagenes/CASTILLO.jpg");
        coleccion4.put("Miku", "src/Buscador_de_Imagenes/MIKU.jpg");
        coleccion4.put("Neon", "src/Buscador_de_Imagenes/NEON.jpg");
        for (Object x : coleccion4.keySet()) {
            modeloAnime.addElement(String.valueOf(x));
        }
        //---------------------------------------------------------------------
        ListCaricatura.setModel(modeloCaricatura);
        coleccion5.put("Luna", "src/Buscador_de_Imagenes/LUNA.jpeg");
        coleccion5.put("Huron", "src/Buscador_de_Imagenes/HURON.jpeg");
        coleccion5.put("Comiendo Helado", "src/Buscador_de_Imagenes/COMIENDO HELADO.jpeg");
        coleccion5.put("Pelirroja", "src/Buscador_de_Imagenes/PELIRROJA.jpeg");
        coleccion5.put("Abrazo", "src/Buscador_de_Imagenes/ABRAZO.jpeg");
        for (Object x : coleccion5.keySet()) {
            modeloCaricatura.addElement(String.valueOf(x));
        }
        //---------------------------------------------------------------------
        ListLeagueOfLegends.setModel(modeloLeagueOfLegends);
        coleccion6.put("Dragon", "src/Buscador_de_Imagenes/DRAGON.jpg");
        coleccion6.put("Samurai", "src/Buscador_de_Imagenes/SAMURAI.jpg");
        coleccion6.put("KDA", "src/Buscador_de_Imagenes/KDA.jpg");
        coleccion6.put("Leyendas", "src/Buscador_de_Imagenes/LEYENDAS.jpg");
        coleccion6.put("Tigre", "src/Buscador_de_Imagenes/TIGRE.jpg");
        for (Object x : coleccion6.keySet()) {
            modeloLeagueOfLegends.addElement(String.valueOf(x));
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        jScrollPane4 = new javax.swing.JScrollPane();
        ListAnimales = new javax.swing.JList<>();
        lblImagen = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        ListPaisajes = new javax.swing.JList<>();
        jScrollPane1 = new javax.swing.JScrollPane();
        ListAutos = new javax.swing.JList<>();
        jScrollPane6 = new javax.swing.JScrollPane();
        ListCaricatura = new javax.swing.JList<>();
        jScrollPane3 = new javax.swing.JScrollPane();
        ListLeagueOfLegends = new javax.swing.JList<>();
        jLabel8 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jScrollPane5 = new javax.swing.JScrollPane();
        ListAnime = new javax.swing.JList<>();
        jLabel3 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        btnSalir = new javax.swing.JButton();

        jButton1.setText("jButton1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setBackground(new java.awt.Color(204, 204, 204));

        jPanel1.setBackground(new java.awt.Color(0, 153, 153));
        jPanel1.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));

        ListAnimales.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                ListAnimalesValueChanged(evt);
            }
        });
        jScrollPane4.setViewportView(ListAnimales);

        lblImagen.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblImagen.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0), 3));
        lblImagen.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        lblImagen.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel5.setText("Anime");

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel7.setText("LeagueOfLegends");

        ListPaisajes.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                ListPaisajesValueChanged(evt);
            }
        });
        jScrollPane2.setViewportView(ListPaisajes);

        ListAutos.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                ListAutosValueChanged(evt);
            }
        });
        jScrollPane1.setViewportView(ListAutos);

        ListCaricatura.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                ListCaricaturaValueChanged(evt);
            }
        });
        jScrollPane6.setViewportView(ListCaricatura);

        ListLeagueOfLegends.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                ListLeagueOfLegendsValueChanged(evt);
            }
        });
        jScrollPane3.setViewportView(ListLeagueOfLegends);

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel8.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel8.setText("CATEGORIAS");
        jLabel8.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        jLabel8.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel2.setText("Animales");

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel4.setText("Paisajes");

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel6.setText("Caricatura");

        ListAnime.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                ListAnimeValueChanged(evt);
            }
        });
        jScrollPane5.setViewportView(ListAnime);

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel3.setText("Autos");

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("GENESIS - BUSCADOR DE IMAGENES");
        jLabel1.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        jLabel1.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);

        btnSalir.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnSalir.setText("SALIR");
        btnSalir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSalirActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 1040, Short.MAX_VALUE)
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel1Layout.createSequentialGroup()
                    .addContainerGap()
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(lblImagen, javax.swing.GroupLayout.DEFAULT_SIZE, 1020, Short.MAX_VALUE)
                        .addGroup(jPanel1Layout.createSequentialGroup()
                            .addGap(43, 43, 43)
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(jLabel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel8, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGroup(jPanel1Layout.createSequentialGroup()
                                    .addGap(130, 130, 130)
                                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 128, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jScrollPane5, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jScrollPane6, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGroup(jPanel1Layout.createSequentialGroup()
                                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(jScrollPane4, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                    .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jLabel5, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jLabel6, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jLabel7)))
                            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btnSalir, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addContainerGap()))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 840, Short.MAX_VALUE)
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel1Layout.createSequentialGroup()
                    .addContainerGap()
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel1)
                        .addComponent(btnSalir))
                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 54, Short.MAX_VALUE)
                    .addComponent(jLabel8, javax.swing.GroupLayout.PREFERRED_SIZE, 17, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                        .addGroup(jPanel1Layout.createSequentialGroup()
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                .addComponent(jLabel2)
                                .addComponent(jLabel3)
                                .addComponent(jLabel4)
                                .addComponent(jLabel5)
                                .addComponent(jLabel6)
                                .addComponent(jLabel7))
                            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                    .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                                    .addComponent(jScrollPane4, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                                    .addComponent(jScrollPane5, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addComponent(jScrollPane6, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                    .addComponent(lblImagen, javax.swing.GroupLayout.PREFERRED_SIZE, 600, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap()))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents


    private void ListPaisajesValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_ListPaisajesValueChanged
        for (Object x : coleccion3.keySet()) {
            if (ListPaisajes.getSelectedValue().equals(x)) {
                lblImagen.setIcon(new ImageIcon(coleccion3.get(x)));
            }
        }
    }//GEN-LAST:event_ListPaisajesValueChanged

    private void ListLeagueOfLegendsValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_ListLeagueOfLegendsValueChanged
        for (Object x : coleccion6.keySet()) {
            if (ListLeagueOfLegends.getSelectedValue().equals(x)) {
                lblImagen.setIcon(new ImageIcon(coleccion6.get(x)));
            }
        }
    }//GEN-LAST:event_ListLeagueOfLegendsValueChanged

    private void btnSalirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSalirActionPerformed
        System.exit(0);
    }//GEN-LAST:event_btnSalirActionPerformed

    private void ListAutosValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_ListAutosValueChanged
        for (Object x : coleccion2.keySet()) {
            if (ListAutos.getSelectedValue().equals(x)) {
                lblImagen.setIcon(new ImageIcon(coleccion2.get(x)));
            }
        }
    }//GEN-LAST:event_ListAutosValueChanged

    private void ListAnimalesValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_ListAnimalesValueChanged
        for (Object x : coleccion1.keySet()) {
            if (ListAnimales.getSelectedValue().equals(x)) {
                lblImagen.setIcon(new ImageIcon(coleccion1.get(x)));
            }
        }
    }//GEN-LAST:event_ListAnimalesValueChanged

    private void ListAnimeValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_ListAnimeValueChanged
        for (Object x : coleccion4.keySet()) {
            if (ListAnime.getSelectedValue().equals(x)) {
                lblImagen.setIcon(new ImageIcon(coleccion4.get(x)));
            }
        }
    }//GEN-LAST:event_ListAnimeValueChanged

    private void ListCaricaturaValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_ListCaricaturaValueChanged
        for (Object x : coleccion5.keySet()) {
            if (ListCaricatura.getSelectedValue().equals(x)) {
                lblImagen.setIcon(new ImageIcon(coleccion5.get(x)));
            }
        }
    }//GEN-LAST:event_ListCaricaturaValueChanged

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Proyecto_Final.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Proyecto_Final.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Proyecto_Final.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Proyecto_Final.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Proyecto_Final().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JList<String> ListAnimales;
    private javax.swing.JList<String> ListAnime;
    private javax.swing.JList<String> ListAutos;
    private javax.swing.JList<String> ListCaricatura;
    private javax.swing.JList<String> ListLeagueOfLegends;
    private javax.swing.JList<String> ListPaisajes;
    private javax.swing.JButton btnSalir;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JScrollPane jScrollPane4;
    private javax.swing.JScrollPane jScrollPane5;
    private javax.swing.JScrollPane jScrollPane6;
    private javax.swing.JLabel lblImagen;
    // End of variables declaration//GEN-END:variables
}
