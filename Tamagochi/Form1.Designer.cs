﻿using System.Drawing;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace Tamagochi
{
    partial class Tamagochi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tamagochi));
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lb_lvl = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_pets = new System.Windows.Forms.Button();
            this.pbox_hunger = new System.Windows.Forms.PictureBox();
            this.pbox_health = new System.Windows.Forms.PictureBox();
            this.pb_pet = new System.Windows.Forms.PictureBox();
            this.chicken_2_30 = new System.Windows.Forms.PictureBox();
            this.syringe_3_25 = new System.Windows.Forms.PictureBox();
            this.pipetca_3_15 = new System.Windows.Forms.PictureBox();
            this.bluepill_3_10 = new System.Windows.Forms.PictureBox();
            this.redpill_3_10 = new System.Windows.Forms.PictureBox();
            this.band_3_5 = new System.Windows.Forms.PictureBox();
            this.hotdog_2_20 = new System.Windows.Forms.PictureBox();
            this.cake_2_10 = new System.Windows.Forms.PictureBox();
            this.salat_2_15 = new System.Windows.Forms.PictureBox();
            this.apple_2_10 = new System.Windows.Forms.PictureBox();
            this.towel_1_5 = new System.Windows.Forms.PictureBox();
            this.water_1_15 = new System.Windows.Forms.PictureBox();
            this.sponge_1_15 = new System.Windows.Forms.PictureBox();
            this.soap_1_10 = new System.Windows.Forms.PictureBox();
            this.btn_bath = new System.Windows.Forms.Button();
            this.btn_kitchen = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_heal = new System.Windows.Forms.Button();
            this.games_4_20 = new System.Windows.Forms.PictureBox();
            this.paint_4_5 = new System.Windows.Forms.PictureBox();
            this.basketball_4_10 = new System.Windows.Forms.PictureBox();
            this.football_4_10 = new System.Windows.Forms.PictureBox();
            this.tbc_menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbox_happiness = new System.Windows.Forms.PictureBox();
            this.pbox_cleanliness = new System.Windows.Forms.PictureBox();
            this.pb_exp = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.pb_health = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.pb_hunger = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.pb_happiness = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.pb_cleanliness = new ExtendedDotNET.Controls.Progress.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_hunger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_health)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken_2_30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syringe_3_25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetca_3_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluepill_3_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redpill_3_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.band_3_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotdog_2_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cake_2_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salat_2_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_2_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towel_1_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_1_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponge_1_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soap_1_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.games_4_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paint_4_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketball_4_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_4_10)).BeginInit();
            this.tbc_menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_happiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_cleanliness)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Bisque;
            this.btn_prev.BackgroundImage = global::Tamagochi.Properties.Resources.fla;
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
            this.btn_next.BackColor = System.Drawing.Color.Bisque;
            this.btn_next.BackgroundImage = global::Tamagochi.Properties.Resources.flat_arrow_collection_fotor;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Location = new System.Drawing.Point(1096, 350);
            this.btn_next.Name = "btn_next";
            this.btn_next.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_next.Size = new System.Drawing.Size(66, 130);
            this.btn_next.TabIndex = 2;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lb_lvl
            // 
            this.lb_lvl.AutoSize = true;
            this.lb_lvl.BackColor = System.Drawing.Color.Transparent;
            this.lb_lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_lvl.ForeColor = System.Drawing.Color.Blue;
            this.lb_lvl.Location = new System.Drawing.Point(437, 137);
            this.lb_lvl.Name = "lb_lvl";
            this.lb_lvl.Size = new System.Drawing.Size(79, 32);
            this.lb_lvl.TabIndex = 9;
            this.lb_lvl.Text = "Lvl 1";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Bisque;
            this.btn_settings.BackgroundImage = global::Tamagochi.Properties.Resources.setting_fotor_bg_remover_2024032421319_3;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.ForeColor = System.Drawing.Color.Transparent;
            this.btn_settings.Location = new System.Drawing.Point(28, 28);
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
            this.btn_pets.Location = new System.Drawing.Point(139, 95);
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
            this.pbox_hunger.Location = new System.Drawing.Point(844, 98);
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
            // pb_pet
            // 
            this.pb_pet.BackColor = System.Drawing.Color.Transparent;
            this.pb_pet.BackgroundImage = global::Tamagochi.Properties.Resources.dog;
            this.pb_pet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pet.Location = new System.Drawing.Point(410, 221);
            this.pb_pet.Name = "pb_pet";
            this.pb_pet.Size = new System.Drawing.Size(393, 390);
            this.pb_pet.TabIndex = 3;
            this.pb_pet.TabStop = false;
            this.pb_pet.DragDrop += new System.Windows.Forms.DragEventHandler(this.pet_DragDrop);
            this.pb_pet.DragEnter += new System.Windows.Forms.DragEventHandler(this.pet_DragEnter);
            // 
            // chicken_2_30
            // 
            this.chicken_2_30.BackColor = System.Drawing.Color.Transparent;
            this.chicken_2_30.BackgroundImage = global::Tamagochi.Properties.Resources.chicken_action_fotor_bg_remover_20240323205151;
            this.chicken_2_30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chicken_2_30.Location = new System.Drawing.Point(572, 8);
            this.chicken_2_30.Name = "chicken_2_30";
            this.chicken_2_30.Size = new System.Drawing.Size(110, 97);
            this.chicken_2_30.TabIndex = 4;
            this.chicken_2_30.TabStop = false;
            this.chicken_2_30.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // syringe_3_25
            // 
            this.syringe_3_25.BackColor = System.Drawing.Color.Transparent;
            this.syringe_3_25.BackgroundImage = global::Tamagochi.Properties.Resources.syringe_action_fotor_bg_remover_20240323205516;
            this.syringe_3_25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.syringe_3_25.Location = new System.Drawing.Point(570, 9);
            this.syringe_3_25.Name = "syringe_3_25";
            this.syringe_3_25.Size = new System.Drawing.Size(110, 97);
            this.syringe_3_25.TabIndex = 4;
            this.syringe_3_25.TabStop = false;
            this.syringe_3_25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // pipetca_3_15
            // 
            this.pipetca_3_15.BackColor = System.Drawing.Color.Transparent;
            this.pipetca_3_15.BackgroundImage = global::Tamagochi.Properties.Resources.pipetca_action_fotor_bg_remover_20240323205552;
            this.pipetca_3_15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipetca_3_15.Location = new System.Drawing.Point(432, 8);
            this.pipetca_3_15.Name = "pipetca_3_15";
            this.pipetca_3_15.Size = new System.Drawing.Size(110, 97);
            this.pipetca_3_15.TabIndex = 3;
            this.pipetca_3_15.TabStop = false;
            this.pipetca_3_15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // bluepill_3_10
            // 
            this.bluepill_3_10.BackColor = System.Drawing.Color.Transparent;
            this.bluepill_3_10.BackgroundImage = global::Tamagochi.Properties.Resources.pill_action_fotor_bg_remover_2024032320557;
            this.bluepill_3_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bluepill_3_10.Location = new System.Drawing.Point(298, 8);
            this.bluepill_3_10.Name = "bluepill_3_10";
            this.bluepill_3_10.Size = new System.Drawing.Size(110, 98);
            this.bluepill_3_10.TabIndex = 2;
            this.bluepill_3_10.TabStop = false;
            this.bluepill_3_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // redpill_3_10
            // 
            this.redpill_3_10.BackColor = System.Drawing.Color.Transparent;
            this.redpill_3_10.BackgroundImage = global::Tamagochi.Properties.Resources.pill2_action1;
            this.redpill_3_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redpill_3_10.Location = new System.Drawing.Point(159, 8);
            this.redpill_3_10.Name = "redpill_3_10";
            this.redpill_3_10.Size = new System.Drawing.Size(110, 97);
            this.redpill_3_10.TabIndex = 1;
            this.redpill_3_10.TabStop = false;
            this.redpill_3_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // band_3_5
            // 
            this.band_3_5.BackColor = System.Drawing.Color.Transparent;
            this.band_3_5.BackgroundImage = global::Tamagochi.Properties.Resources.band_action_fotor_bg_remover_20240323205432;
            this.band_3_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.band_3_5.Location = new System.Drawing.Point(24, 8);
            this.band_3_5.Name = "band_3_5";
            this.band_3_5.Size = new System.Drawing.Size(110, 97);
            this.band_3_5.TabIndex = 0;
            this.band_3_5.TabStop = false;
            this.band_3_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // hotdog_2_20
            // 
            this.hotdog_2_20.BackColor = System.Drawing.Color.Transparent;
            this.hotdog_2_20.BackgroundImage = global::Tamagochi.Properties.Resources.hotdog_action_fotor_bg_remover_2024032320515;
            this.hotdog_2_20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hotdog_2_20.Location = new System.Drawing.Point(442, 8);
            this.hotdog_2_20.Name = "hotdog_2_20";
            this.hotdog_2_20.Size = new System.Drawing.Size(110, 97);
            this.hotdog_2_20.TabIndex = 3;
            this.hotdog_2_20.TabStop = false;
            this.hotdog_2_20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // cake_2_10
            // 
            this.cake_2_10.BackColor = System.Drawing.Color.Transparent;
            this.cake_2_10.BackgroundImage = global::Tamagochi.Properties.Resources.muffin_action_fotor_bg_remover_20240323205140;
            this.cake_2_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cake_2_10.Location = new System.Drawing.Point(299, 6);
            this.cake_2_10.Name = "cake_2_10";
            this.cake_2_10.Size = new System.Drawing.Size(110, 98);
            this.cake_2_10.TabIndex = 2;
            this.cake_2_10.TabStop = false;
            this.cake_2_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // salat_2_15
            // 
            this.salat_2_15.BackColor = System.Drawing.Color.Transparent;
            this.salat_2_15.BackgroundImage = global::Tamagochi.Properties.Resources.salat_action_fotor_bg_remover_20240323205128;
            this.salat_2_15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salat_2_15.Location = new System.Drawing.Point(159, 6);
            this.salat_2_15.Name = "salat_2_15";
            this.salat_2_15.Size = new System.Drawing.Size(110, 97);
            this.salat_2_15.TabIndex = 1;
            this.salat_2_15.TabStop = false;
            this.salat_2_15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // apple_2_10
            // 
            this.apple_2_10.BackColor = System.Drawing.Color.Transparent;
            this.apple_2_10.BackgroundImage = global::Tamagochi.Properties.Resources.apple_action_fotor_bg_remover_20240323205115;
            this.apple_2_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apple_2_10.Location = new System.Drawing.Point(20, 6);
            this.apple_2_10.Name = "apple_2_10";
            this.apple_2_10.Size = new System.Drawing.Size(110, 97);
            this.apple_2_10.TabIndex = 0;
            this.apple_2_10.TabStop = false;
            this.apple_2_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // towel_1_5
            // 
            this.towel_1_5.BackColor = System.Drawing.Color.Transparent;
            this.towel_1_5.BackgroundImage = global::Tamagochi.Properties.Resources._6f8bdaab_no_bg_preview__carve_photos_;
            this.towel_1_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.towel_1_5.Location = new System.Drawing.Point(561, 8);
            this.towel_1_5.Name = "towel_1_5";
            this.towel_1_5.Size = new System.Drawing.Size(110, 97);
            this.towel_1_5.TabIndex = 3;
            this.towel_1_5.TabStop = false;
            this.towel_1_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // water_1_15
            // 
            this.water_1_15.BackColor = System.Drawing.Color.Transparent;
            this.water_1_15.BackgroundImage = global::Tamagochi.Properties.Resources.water_action;
            this.water_1_15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.water_1_15.Location = new System.Drawing.Point(407, 8);
            this.water_1_15.Name = "water_1_15";
            this.water_1_15.Size = new System.Drawing.Size(96, 88);
            this.water_1_15.TabIndex = 2;
            this.water_1_15.TabStop = false;
            this.water_1_15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // sponge_1_15
            // 
            this.sponge_1_15.BackColor = System.Drawing.Color.Transparent;
            this.sponge_1_15.BackgroundImage = global::Tamagochi.Properties.Resources.wash_action_fotor_bg_remover_20240323205041;
            this.sponge_1_15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sponge_1_15.Location = new System.Drawing.Point(215, 16);
            this.sponge_1_15.Name = "sponge_1_15";
            this.sponge_1_15.Size = new System.Drawing.Size(110, 80);
            this.sponge_1_15.TabIndex = 1;
            this.sponge_1_15.TabStop = false;
            this.sponge_1_15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // soap_1_10
            // 
            this.soap_1_10.BackColor = System.Drawing.Color.Transparent;
            this.soap_1_10.BackgroundImage = global::Tamagochi.Properties.Resources.soap_action_transformed;
            this.soap_1_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soap_1_10.Location = new System.Drawing.Point(39, 8);
            this.soap_1_10.Name = "soap_1_10";
            this.soap_1_10.Size = new System.Drawing.Size(110, 97);
            this.soap_1_10.TabIndex = 0;
            this.soap_1_10.TabStop = false;
            this.soap_1_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // btn_bath
            // 
            this.btn_bath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            this.btn_kitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            this.btn_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            this.btn_heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_heal.BackgroundImage = global::Tamagochi.Properties.Resources.health_icon;
            this.btn_heal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_heal.Location = new System.Drawing.Point(993, 617);
            this.btn_heal.Name = "btn_heal";
            this.btn_heal.Size = new System.Drawing.Size(77, 69);
            this.btn_heal.TabIndex = 16;
            this.btn_heal.UseVisualStyleBackColor = false;
            this.btn_heal.Click += new System.EventHandler(this.btn_heal_Click);
            // 
            // games_4_20
            // 
            this.games_4_20.BackColor = System.Drawing.Color.Transparent;
            this.games_4_20.BackgroundImage = global::Tamagochi.Properties.Resources.game_action_fotor_bg_remover_20240323205343;
            this.games_4_20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.games_4_20.Location = new System.Drawing.Point(504, 6);
            this.games_4_20.Name = "games_4_20";
            this.games_4_20.Size = new System.Drawing.Size(140, 97);
            this.games_4_20.TabIndex = 3;
            this.games_4_20.TabStop = false;
            this.games_4_20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // paint_4_5
            // 
            this.paint_4_5.BackColor = System.Drawing.Color.Transparent;
            this.paint_4_5.BackgroundImage = global::Tamagochi.Properties.Resources.paint_action_fotor_bg_remover_20240323205337;
            this.paint_4_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paint_4_5.Location = new System.Drawing.Point(350, 5);
            this.paint_4_5.Name = "paint_4_5";
            this.paint_4_5.Size = new System.Drawing.Size(110, 98);
            this.paint_4_5.TabIndex = 2;
            this.paint_4_5.TabStop = false;
            this.paint_4_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // basketball_4_10
            // 
            this.basketball_4_10.BackColor = System.Drawing.Color.Transparent;
            this.basketball_4_10.BackgroundImage = global::Tamagochi.Properties.Resources.basketball_action__fotor_bg_remover_20240323205352;
            this.basketball_4_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basketball_4_10.Location = new System.Drawing.Point(208, 6);
            this.basketball_4_10.Name = "basketball_4_10";
            this.basketball_4_10.Size = new System.Drawing.Size(110, 97);
            this.basketball_4_10.TabIndex = 1;
            this.basketball_4_10.TabStop = false;
            this.basketball_4_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // football_4_10
            // 
            this.football_4_10.BackColor = System.Drawing.Color.Transparent;
            this.football_4_10.BackgroundImage = global::Tamagochi.Properties.Resources.football_action_fotor_bg_remover_20240323205422;
            this.football_4_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.football_4_10.Location = new System.Drawing.Point(65, 6);
            this.football_4_10.Name = "football_4_10";
            this.football_4_10.Size = new System.Drawing.Size(110, 97);
            this.football_4_10.TabIndex = 0;
            this.football_4_10.TabStop = false;
            this.football_4_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // tbc_menu
            // 
            this.tbc_menu.Controls.Add(this.tabPage1);
            this.tbc_menu.Controls.Add(this.tabPage2);
            this.tbc_menu.Controls.Add(this.tabPage3);
            this.tbc_menu.Controls.Add(this.tabPage4);
            this.tbc_menu.Location = new System.Drawing.Point(257, 617);
            this.tbc_menu.Name = "tbc_menu";
            this.tbc_menu.SelectedIndex = 0;
            this.tbc_menu.Size = new System.Drawing.Size(716, 144);
            this.tbc_menu.TabIndex = 20;
            this.tbc_menu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbc_menu_DrawItem);
            this.tbc_menu.SelectedIndexChanged += new System.EventHandler(this.tbc_menu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.towel_1_5);
            this.tabPage1.Controls.Add(this.sponge_1_15);
            this.tabPage1.Controls.Add(this.water_1_15);
            this.tabPage1.Controls.Add(this.soap_1_10);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 111);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ванная";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.chicken_2_30);
            this.tabPage2.Controls.Add(this.apple_2_10);
            this.tabPage2.Controls.Add(this.hotdog_2_20);
            this.tabPage2.Controls.Add(this.salat_2_15);
            this.tabPage2.Controls.Add(this.cake_2_10);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 111);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Кухня";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage3.Controls.Add(this.syringe_3_25);
            this.tabPage3.Controls.Add(this.band_3_5);
            this.tabPage3.Controls.Add(this.pipetca_3_15);
            this.tabPage3.Controls.Add(this.redpill_3_10);
            this.tabPage3.Controls.Add(this.bluepill_3_10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(708, 111);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Лечение";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Khaki;
            this.tabPage4.Controls.Add(this.games_4_20);
            this.tabPage4.Controls.Add(this.paint_4_5);
            this.tabPage4.Controls.Add(this.football_4_10);
            this.tabPage4.Controls.Add(this.basketball_4_10);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(708, 111);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Игры";
            // 
            // timer
            // 
            this.timer.Interval = 7000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbox_happiness
            // 
            this.pbox_happiness.BackColor = System.Drawing.Color.Transparent;
            this.pbox_happiness.BackgroundImage = global::Tamagochi.Properties.Resources._2900642_25513_fotor_bg_remover_20240325212352;
            this.pbox_happiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox_happiness.Location = new System.Drawing.Point(844, 154);
            this.pbox_happiness.Name = "pbox_happiness";
            this.pbox_happiness.Size = new System.Drawing.Size(57, 50);
            this.pbox_happiness.TabIndex = 21;
            this.pbox_happiness.TabStop = false;
            // 
            // pbox_cleanliness
            // 
            this.pbox_cleanliness.BackColor = System.Drawing.Color.Transparent;
            this.pbox_cleanliness.BackgroundImage = global::Tamagochi.Properties.Resources.soap_and_bubbles_icon;
            this.pbox_cleanliness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox_cleanliness.Location = new System.Drawing.Point(844, 210);
            this.pbox_cleanliness.Name = "pbox_cleanliness";
            this.pbox_cleanliness.Size = new System.Drawing.Size(57, 50);
            this.pbox_cleanliness.TabIndex = 23;
            this.pbox_cleanliness.TabStop = false;
            // 
            // pb_exp
            // 
            this.pb_exp.BarOffset = 1;
            this.pb_exp.Caption = "Progress";
            this.pb_exp.CaptionColor = System.Drawing.Color.Black;
            this.pb_exp.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_exp.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_exp.ChangeByMouse = false;
            this.pb_exp.DashSpace = 2;
            this.pb_exp.DashWidth = 5;
            this.pb_exp.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
            this.pb_exp.EdgeColor = System.Drawing.Color.Gray;
            this.pb_exp.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pb_exp.EdgeWidth = 1;
            this.pb_exp.FloodPercentage = 0.2F;
            this.pb_exp.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_exp.Invert = false;
            this.pb_exp.Location = new System.Drawing.Point(522, 137);
            this.pb_exp.MainColor = System.Drawing.Color.RoyalBlue;
            this.pb_exp.Maximum = 100;
            this.pb_exp.Minimum = 0;
            this.pb_exp.Name = "pb_exp";
            this.pb_exp.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_exp.ProgressBackColor = System.Drawing.Color.SeaShell;
            this.pb_exp.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_exp.SecondColor = System.Drawing.Color.White;
            this.pb_exp.Shadow = true;
            this.pb_exp.ShadowOffset = 1;
            this.pb_exp.Size = new System.Drawing.Size(258, 32);
            this.pb_exp.Step = 1;
            this.pb_exp.TabIndex = 25;
            this.pb_exp.TextAntialias = true;
            this.pb_exp.Value = 33;
            // 
            // pb_health
            // 
            this.pb_health.BarOffset = 1;
            this.pb_health.Caption = "Progress";
            this.pb_health.CaptionColor = System.Drawing.Color.Black;
            this.pb_health.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_health.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_health.ChangeByMouse = false;
            this.pb_health.DashSpace = 2;
            this.pb_health.DashWidth = 5;
            this.pb_health.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
            this.pb_health.EdgeColor = System.Drawing.Color.Gray;
            this.pb_health.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pb_health.EdgeWidth = 1;
            this.pb_health.FloodPercentage = 0.2F;
            this.pb_health.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_health.Invert = false;
            this.pb_health.Location = new System.Drawing.Point(933, 54);
            this.pb_health.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pb_health.Maximum = 100;
            this.pb_health.Minimum = 0;
            this.pb_health.Name = "pb_health";
            this.pb_health.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_health.ProgressBackColor = System.Drawing.Color.SeaShell;
            this.pb_health.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_health.SecondColor = System.Drawing.Color.White;
            this.pb_health.Shadow = true;
            this.pb_health.ShadowOffset = 1;
            this.pb_health.Size = new System.Drawing.Size(229, 25);
            this.pb_health.Step = 1;
            this.pb_health.TabIndex = 26;
            this.pb_health.TextAntialias = true;
            this.pb_health.Value = 33;
            // 
            // pb_hunger
            // 
            this.pb_hunger.BarOffset = 1;
            this.pb_hunger.Caption = "Progress";
            this.pb_hunger.CaptionColor = System.Drawing.Color.Black;
            this.pb_hunger.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_hunger.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_hunger.ChangeByMouse = false;
            this.pb_hunger.DashSpace = 2;
            this.pb_hunger.DashWidth = 5;
            this.pb_hunger.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
            this.pb_hunger.EdgeColor = System.Drawing.Color.Gray;
            this.pb_hunger.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pb_hunger.EdgeWidth = 1;
            this.pb_hunger.FloodPercentage = 0.2F;
            this.pb_hunger.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_hunger.Invert = false;
            this.pb_hunger.Location = new System.Drawing.Point(933, 113);
            this.pb_hunger.MainColor = System.Drawing.Color.Coral;
            this.pb_hunger.Maximum = 100;
            this.pb_hunger.Minimum = 0;
            this.pb_hunger.Name = "pb_hunger";
            this.pb_hunger.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_hunger.ProgressBackColor = System.Drawing.Color.SeaShell;
            this.pb_hunger.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_hunger.SecondColor = System.Drawing.Color.White;
            this.pb_hunger.Shadow = true;
            this.pb_hunger.ShadowOffset = 1;
            this.pb_hunger.Size = new System.Drawing.Size(229, 25);
            this.pb_hunger.Step = 1;
            this.pb_hunger.TabIndex = 27;
            this.pb_hunger.TextAntialias = true;
            this.pb_hunger.Value = 33;
            // 
            // pb_happiness
            // 
            this.pb_happiness.BarOffset = 1;
            this.pb_happiness.Caption = "Progress";
            this.pb_happiness.CaptionColor = System.Drawing.Color.Black;
            this.pb_happiness.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_happiness.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_happiness.ChangeByMouse = false;
            this.pb_happiness.DashSpace = 2;
            this.pb_happiness.DashWidth = 5;
            this.pb_happiness.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
            this.pb_happiness.EdgeColor = System.Drawing.Color.Gray;
            this.pb_happiness.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pb_happiness.EdgeWidth = 1;
            this.pb_happiness.FloodPercentage = 0.2F;
            this.pb_happiness.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_happiness.Invert = false;
            this.pb_happiness.Location = new System.Drawing.Point(933, 166);
            this.pb_happiness.MainColor = System.Drawing.Color.Gold;
            this.pb_happiness.Maximum = 100;
            this.pb_happiness.Minimum = 0;
            this.pb_happiness.Name = "pb_happiness";
            this.pb_happiness.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_happiness.ProgressBackColor = System.Drawing.Color.SeaShell;
            this.pb_happiness.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_happiness.SecondColor = System.Drawing.Color.White;
            this.pb_happiness.Shadow = true;
            this.pb_happiness.ShadowOffset = 1;
            this.pb_happiness.Size = new System.Drawing.Size(229, 25);
            this.pb_happiness.Step = 1;
            this.pb_happiness.TabIndex = 28;
            this.pb_happiness.TextAntialias = true;
            this.pb_happiness.Value = 33;
            // 
            // pb_cleanliness
            // 
            this.pb_cleanliness.BarOffset = 1;
            this.pb_cleanliness.Caption = "Progress";
            this.pb_cleanliness.CaptionColor = System.Drawing.Color.Black;
            this.pb_cleanliness.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_cleanliness.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_cleanliness.ChangeByMouse = false;
            this.pb_cleanliness.DashSpace = 2;
            this.pb_cleanliness.DashWidth = 5;
            this.pb_cleanliness.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
            this.pb_cleanliness.EdgeColor = System.Drawing.Color.Gray;
            this.pb_cleanliness.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pb_cleanliness.EdgeWidth = 1;
            this.pb_cleanliness.FloodPercentage = 0.2F;
            this.pb_cleanliness.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_cleanliness.Invert = false;
            this.pb_cleanliness.Location = new System.Drawing.Point(933, 221);
            this.pb_cleanliness.MainColor = System.Drawing.Color.Plum;
            this.pb_cleanliness.Maximum = 100;
            this.pb_cleanliness.Minimum = 0;
            this.pb_cleanliness.Name = "pb_cleanliness";
            this.pb_cleanliness.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_cleanliness.ProgressBackColor = System.Drawing.Color.White;
            this.pb_cleanliness.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_cleanliness.SecondColor = System.Drawing.Color.White;
            this.pb_cleanliness.Shadow = true;
            this.pb_cleanliness.ShadowOffset = 1;
            this.pb_cleanliness.Size = new System.Drawing.Size(229, 25);
            this.pb_cleanliness.Step = 1;
            this.pb_cleanliness.TabIndex = 29;
            this.pb_cleanliness.TextAntialias = true;
            this.pb_cleanliness.Value = 33;
            // 
            // Tamagochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tamagochi.Properties.Resources.bath_fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 789);
            this.Controls.Add(this.pb_cleanliness);
            this.Controls.Add(this.pb_happiness);
            this.Controls.Add(this.pb_hunger);
            this.Controls.Add(this.pb_health);
            this.Controls.Add(this.pb_exp);
            this.Controls.Add(this.pbox_cleanliness);
            this.Controls.Add(this.pbox_happiness);
            this.Controls.Add(this.tbc_menu);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_heal);
            this.Controls.Add(this.btn_kitchen);
            this.Controls.Add(this.btn_bath);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_pets);
            this.Controls.Add(this.lb_lvl);
            this.Controls.Add(this.pbox_hunger);
            this.Controls.Add(this.pbox_health);
            this.Controls.Add(this.pb_pet);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tamagochi";
            this.Text = "Tamagochi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_hunger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_health)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken_2_30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syringe_3_25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetca_3_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluepill_3_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redpill_3_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.band_3_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotdog_2_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cake_2_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salat_2_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_2_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towel_1_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_1_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponge_1_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soap_1_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.games_4_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paint_4_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketball_4_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_4_10)).EndInit();
            this.tbc_menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_happiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_cleanliness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pb_pet;
        private System.Windows.Forms.PictureBox pbox_health;
        private System.Windows.Forms.PictureBox pbox_hunger;
        private System.Windows.Forms.Label lb_lvl;
        private System.Windows.Forms.Button btn_pets;
        private System.Windows.Forms.Button btn_settings;
        private PictureBox towel_1_5;
        private PictureBox water_1_15;
        private PictureBox sponge_1_15;
        private PictureBox soap_1_10;
        private Button btn_bath;
        private Button btn_kitchen;
        private Button btn_play;
        private Button btn_heal;
        private PictureBox hotdog_2_20;
        private PictureBox cake_2_10;
        private PictureBox salat_2_15;
        private PictureBox apple_2_10;
        private PictureBox chicken_2_30;
        private PictureBox syringe_3_25;
        private PictureBox pipetca_3_15;
        private PictureBox bluepill_3_10;
        private PictureBox redpill_3_10;
        private PictureBox band_3_5;
        private PictureBox games_4_20;
        private PictureBox paint_4_5;
        private PictureBox basketball_4_10;
        private PictureBox football_4_10;
        private TabControl tbc_menu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Timer timer;
        private PictureBox pbox_happiness;
        private PictureBox pbox_cleanliness;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_exp;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_health;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_hunger;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_happiness;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_cleanliness;
    }
}

