   M S B A M L   `   `   `  ����M  IAuftragsverwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AuftragsverwaltungAuftragsverwaltung  5   	   &     Auftragsverwaltung.ArtikelWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Auftragsverwaltung     5   	     � Title$  ArtikelWindow��5   	   $	��450��6   $	��800��6,   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 	LightCyan��6    � Offset$	 0.0Q�61   � 5      $ LightSkyBlue��6   $	 1.0Q�64   5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� $��0��6   $��Artikelverwaltung��6!   $��20(�6:   $��10q�6H   �� 5   
   -   5         ��Name$ ArtikelSuchen��5      $��1��6   $��10q�6^   6l   �� 5   
   -   5         ��Name$ ArtikelHinzufuegen��5   .   $��1��6   $��1��6   $��Hinzufügen��6J   $��10q�6_   6m   �� 5    
   -   5        $ ArtikelEditieren��5    .   $��1��6   $��2��6   $��	Editieren��6H   $��10q�6\   6j   �� 5!   
   -   5        $ ArtikelLoeschen��5!   .   $��1��6   $��3��6   $��Löschen��6G   $��10q�6Y   6g   �� 5#   
   -   5        $��Artikel��5#      ���#cdcdcd$��2��68   $��4��6E   $��10q�6Y   	 �� View	 5$      �� 5%      .P�5&      �� $��Checkbox��6%   
 �� Width$
 60��67   �� 5'      $��Artikelnummer��6%   $	
 100��6<   �� 5(      $��Artikelgruppe��6%   $	
 100��6<   �� 5)      $��Bezeichnung��6%   $	
 100��6:   �� 5*      $��Preis��6%   $	
 100��64   5+      5-      5.      5/      