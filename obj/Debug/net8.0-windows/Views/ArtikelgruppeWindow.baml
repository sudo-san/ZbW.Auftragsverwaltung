   M S B A M L   `   `   `  ����M  IAuftragsverwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Auftragsverwaltung.ViewsAuftragsverwaltung.Views  5   	   2    ,Auftragsverwaltung.Views.ArtikelgruppeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Auftragsverwaltung.Views     5   	     � Title$  ArtikelgruppeWindow��5   	   $	��450��6%   $	��800��62   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 	LightCyan��6    � Offset$	 0.0Q�61   � 5      $ LightSkyBlue��6   $	 1.0Q�64   5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� $��0��6   $��2��6!   $��Artikelgruppenverwaltung��65   $��20(�6U   $��10q�6c   �� 5   
   -   5         ��Name$ ArtikelGruppeSuchen��5      $��1��6   $��10q�6j   6x   �� 5   
   -   5         ��Name$ ArtikelGruppeHinzufuegen��5   .   $��1��6   $��1��6   $��Hinzufügen��6w   $��10q�6�   6�   �� 5    
   -   5        $ ArtikelGruppeEditieren��5    .   $��1��6   $��2��6   $��	Editieren��6N   $��10q�6b   6p   �� 5!   
   -   5        $ ArtikelGruppeLoeschen��5!   .   $��1��6   $��3��6   $��Löschen��6q   $��10q�6�   6�   �� 5#   
   -   5        $��ArtikelGruppeListe��5#      ���#cdcdcd$��2��6C   $��4��6P   $��10q�6d   	 �� View	 5$      �� 5%      .P�5&      �� $��Bezeichnung��6%   
 �� Width$	
 400��6`    �� DisplayMemberBinding 6:   �� *Name+6`   5'      5)      5*      5+      