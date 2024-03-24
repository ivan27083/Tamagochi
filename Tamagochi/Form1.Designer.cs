using System.Drawing;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace Tamagochi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pb_health = new System.Windows.Forms.ProgressBar();
            this.pb_hunger = new System.Windows.Forms.ProgressBar();
            this.pb_exp = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_pets = new System.Windows.Forms.Button();
            this.pbox_hunger = new System.Windows.Forms.PictureBox();
            this.pbox_health = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_bath = new System.Windows.Forms.Button();
            this.btn_kitchen = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_heal = new System.Windows.Forms.Button();
            this.gb_3 = new System.Windows.Forms.GroupBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.gb_4 = new System.Windows.Forms.GroupBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_hunger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_health)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_1.SuspendLayout();
            this.gb_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gb_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.gb_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Transparent;
            this.btn_prev.BackgroundImage = global::Tamagochi.Properties.Resources.arrow;
            this.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prev.Location = new System.Drawing.Point(64, 350);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(66, 130);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.BackgroundImage = global::Tamagochi.Properties.Resources.arrow2;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Location = new System.Drawing.Point(1096, 350);
            this.btn_next.Name = "btn_next";
            this.btn_next.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_next.Size = new System.Drawing.Size(66, 130);
            this.btn_next.TabIndex = 2;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pb_health
            // 
            this.pb_health.ForeColor = System.Drawing.Color.Green;
            this.pb_health.Location = new System.Drawing.Point(933, 53);
            this.pb_health.Name = "pb_health";
            this.pb_health.Size = new System.Drawing.Size(229, 25);
            this.pb_health.TabIndex = 6;
            // 
            // pb_hunger
            // 
            this.pb_hunger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pb_hunger.Location = new System.Drawing.Point(933, 137);
            this.pb_hunger.Name = "pb_hunger";
            this.pb_hunger.Size = new System.Drawing.Size(229, 25);
            this.pb_hunger.TabIndex = 7;
            // 
            // pb_exp
            // 
            this.pb_exp.Location = new System.Drawing.Point(534, 201);
            this.pb_exp.Name = "pb_exp";
            this.pb_exp.Size = new System.Drawing.Size(229, 29);
            this.pb_exp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(450, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lvl 1";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = global::Tamagochi.Properties.Resources.setting_fotor_bg_remover_2024032421319;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.ForeColor = System.Drawing.Color.Transparent;
            this.btn_settings.Location = new System.Drawing.Point(153, 53);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(55, 50);
            this.btn_settings.TabIndex = 11;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_pets
            // 
            this.btn_pets.BackgroundImage = global::Tamagochi.Properties.Resources.pet_logo;
            this.btn_pets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pets.Location = new System.Drawing.Point(153, 137);
            this.btn_pets.Name = "btn_pets";
            this.btn_pets.Size = new System.Drawing.Size(112, 95);
            this.btn_pets.TabIndex = 10;
            this.btn_pets.UseVisualStyleBackColor = true;
            this.btn_pets.Click += new System.EventHandler(this.btn_pets_Click);
            // 
            // pbox_hunger
            // 
            this.pbox_hunger.BackColor = System.Drawing.Color.Transparent;
            this.pbox_hunger.BackgroundImage = global::Tamagochi.Properties.Resources.mea;
            this.pbox_hunger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox_hunger.Location = new System.Drawing.Point(844, 126);
            this.pbox_hunger.Name = "pbox_hunger";
            this.pbox_hunger.Size = new System.Drawing.Size(57, 50);
            this.pbox_hunger.TabIndex = 5;
            this.pbox_hunger.TabStop = false;
            // 
            // pbox_health
            // 
            this.pbox_health.BackColor = System.Drawing.Color.Transparent;
            this.pbox_health.BackgroundImage = global::Tamagochi.Properties.Resources.e1990341_no_bg_preview_carve_photos;
            this.pbox_health.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox_health.Location = new System.Drawing.Point(844, 42);
            this.pbox_health.Name = "pbox_health";
            this.pbox_health.Size = new System.Drawing.Size(57, 50);
            this.pbox_health.TabIndex = 4;
            this.pbox_health.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tamagochi.Properties.Resources.tiger2_fotor_bg_remover_20240324193029;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(431, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 329);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gb_1
            // 
            this.gb_1.BackColor = System.Drawing.SystemColors.Control;
            this.gb_1.Controls.Add(this.gb_2);
            this.gb_1.Controls.Add(this.pictureBox6);
            this.gb_1.Controls.Add(this.pictureBox5);
            this.gb_1.Controls.Add(this.pictureBox4);
            this.gb_1.Controls.Add(this.pictureBox3);
            this.gb_1.Location = new System.Drawing.Point(236, 617);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(751, 147);
            this.gb_1.TabIndex = 13;
            this.gb_1.TabStop = false;
            // 
            // gb_2
            // 
            this.gb_2.BackColor = System.Drawing.SystemColors.Control;
            this.gb_2.Controls.Add(this.pictureBox10);
            this.gb_2.Controls.Add(this.gb_3);
            this.gb_2.Controls.Add(this.pictureBox2);
            this.gb_2.Controls.Add(this.pictureBox7);
            this.gb_2.Controls.Add(this.pictureBox8);
            this.gb_2.Controls.Add(this.pictureBox9);
            this.gb_2.Location = new System.Drawing.Point(0, 0);
            this.gb_2.Name = "gb_2";
            this.gb_2.Size = new System.Drawing.Size(751, 147);
            this.gb_2.TabIndex = 14;
            this.gb_2.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::Tamagochi.Properties.Resources.chicken_action_fotor_bg_remover_20240323205151;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(497, 26);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(110, 97);
            this.pictureBox10.TabIndex = 4;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Tamagochi.Properties.Resources.hotdog_action_fotor_bg_remover_2024032320515;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(381, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 97);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::Tamagochi.Properties.Resources.muffin_action_fotor_bg_remover_20240323205140;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(265, 25);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(110, 98);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::Tamagochi.Properties.Resources.salat_action_fotor_bg_remover_20240323205128;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(149, 26);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(110, 97);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::Tamagochi.Properties.Resources.apple_action_fotor_bg_remover_20240323205115;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(33, 26);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(110, 97);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::Tamagochi.Properties.Resources._6f8bdaab_no_bg_preview__carve_photos_;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(381, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(110, 97);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Tamagochi.Properties.Resources.water_action;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(265, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(96, 88);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Tamagochi.Properties.Resources.wash_action_fotor_bg_remover_20240323205041;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(149, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 80);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Tamagochi.Properties.Resources.soap_action_transformed;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(33, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 97);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btn_bath
            // 
            this.btn_bath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_bath.BackgroundImage = global::Tamagochi.Properties.Resources.shower_icon_fotor_bg_remover_20240323205053;
            this.btn_bath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bath.Location = new System.Drawing.Point(153, 617);
            this.btn_bath.Name = "btn_bath";
            this.btn_bath.Size = new System.Drawing.Size(77, 69);
            this.btn_bath.TabIndex = 14;
            this.btn_bath.UseVisualStyleBackColor = false;
            this.btn_bath.Click += new System.EventHandler(this.btn_bath_Click);
            // 
            // btn_kitchen
            // 
            this.btn_kitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_kitchen.BackgroundImage = global::Tamagochi.Properties.Resources.chicken_1227251;
            this.btn_kitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kitchen.Location = new System.Drawing.Point(153, 692);
            this.btn_kitchen.Name = "btn_kitchen";
            this.btn_kitchen.Size = new System.Drawing.Size(77, 69);
            this.btn_kitchen.TabIndex = 15;
            this.btn_kitchen.UseVisualStyleBackColor = false;
            this.btn_kitchen.Click += new System.EventHandler(this.btn_kitchen_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_play.BackgroundImage = global::Tamagochi.Properties.Resources.abfe78c9c67376a6c2a9732b9afe0e4a;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.Location = new System.Drawing.Point(993, 692);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(77, 69);
            this.btn_play.TabIndex = 17;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_heal
            // 
            this.btn_heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_heal.BackgroundImage = global::Tamagochi.Properties.Resources.health_icon;
            this.btn_heal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_heal.Location = new System.Drawing.Point(993, 617);
            this.btn_heal.Name = "btn_heal";
            this.btn_heal.Size = new System.Drawing.Size(77, 69);
            this.btn_heal.TabIndex = 16;
            this.btn_heal.UseVisualStyleBackColor = false;
            this.btn_heal.Click += new System.EventHandler(this.btn_heal_Click);
            // 
            // gb_3
            // 
            this.gb_3.BackColor = System.Drawing.SystemColors.Control;
            this.gb_3.Controls.Add(this.pictureBox11);
            this.gb_3.Controls.Add(this.pictureBox12);
            this.gb_3.Controls.Add(this.pictureBox13);
            this.gb_3.Controls.Add(this.pictureBox14);
            this.gb_3.Controls.Add(this.pictureBox15);
            this.gb_3.Location = new System.Drawing.Point(0, 0);
            this.gb_3.Name = "gb_3";
            this.gb_3.Size = new System.Drawing.Size(751, 147);
            this.gb_3.TabIndex = 18;
            this.gb_3.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::Tamagochi.Properties.Resources.syringe_action_fotor_bg_remover_20240323205516;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(497, 26);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(110, 97);
            this.pictureBox11.TabIndex = 4;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = global::Tamagochi.Properties.Resources.pipetca_action_fotor_bg_remover_20240323205552;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(381, 26);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(110, 97);
            this.pictureBox12.TabIndex = 3;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BackgroundImage = global::Tamagochi.Properties.Resources.pill_action_fotor_bg_remover_2024032320557;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(265, 25);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(110, 98);
            this.pictureBox13.TabIndex = 2;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = global::Tamagochi.Properties.Resources.pill2_action1;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(149, 26);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(110, 97);
            this.pictureBox14.TabIndex = 1;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BackgroundImage = global::Tamagochi.Properties.Resources.band_action_fotor_bg_remover_20240323205432;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(33, 26);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(110, 97);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            // 
            // gb_4
            // 
            this.gb_4.BackColor = System.Drawing.SystemColors.Control;
            this.gb_4.Controls.Add(this.pictureBox17);
            this.gb_4.Controls.Add(this.pictureBox18);
            this.gb_4.Controls.Add(this.pictureBox19);
            this.gb_4.Controls.Add(this.pictureBox20);
            this.gb_4.Location = new System.Drawing.Point(236, 617);
            this.gb_4.Name = "gb_4";
            this.gb_4.Size = new System.Drawing.Size(751, 147);
            this.gb_4.TabIndex = 19;
            this.gb_4.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.BackgroundImage = global::Tamagochi.Properties.Resources.game_action_fotor_bg_remover_20240323205343;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.Location = new System.Drawing.Point(381, 26);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(140, 97);
            this.pictureBox17.TabIndex = 3;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BackgroundImage = global::Tamagochi.Properties.Resources.paint_action_fotor_bg_remover_20240323205337;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox18.Location = new System.Drawing.Point(265, 25);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(110, 98);
            this.pictureBox18.TabIndex = 2;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.BackgroundImage = global::Tamagochi.Properties.Resources.basketball_action__fotor_bg_remover_20240323205352;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.Location = new System.Drawing.Point(149, 26);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(110, 97);
            this.pictureBox19.TabIndex = 1;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.BackgroundImage = global::Tamagochi.Properties.Resources.football_action_fotor_bg_remover_20240323205422;
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox20.Location = new System.Drawing.Point(33, 26);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(110, 97);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tamagochi.Properties.Resources.bath_fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 789);
            this.Controls.Add(this.gb_4);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_heal);
            this.Controls.Add(this.btn_kitchen);
            this.Controls.Add(this.btn_bath);
            this.Controls.Add(this.gb_1);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_pets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_exp);
            this.Controls.Add(this.pb_hunger);
            this.Controls.Add(this.pb_health);
            this.Controls.Add(this.pbox_hunger);
            this.Controls.Add(this.pbox_health);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_hunger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_health)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_1.ResumeLayout(false);
            this.gb_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gb_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.gb_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbox_health;
        private System.Windows.Forms.PictureBox pbox_hunger;
        private System.Windows.Forms.ProgressBar pb_health;
        private System.Windows.Forms.ProgressBar pb_hunger;
        private System.Windows.Forms.ProgressBar pb_exp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pets;
        private System.Windows.Forms.Button btn_settings;
        private GroupBox gb_1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button btn_bath;
        private Button btn_kitchen;
        private Button btn_play;
        private Button btn_heal;
        private GroupBox gb_2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private GroupBox gb_3;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private GroupBox gb_4;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
    }
}

