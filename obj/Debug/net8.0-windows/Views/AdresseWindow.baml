   M S B A M L   `   `   `  ����M  IAuftragsverwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AuftragsverwaltungAuftragsverwaltung  5   	   &     Auftragsverwaltung.AdresseWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Auftragsverwaltung     5   	     � Title$  AdresseWindow��5   	   $	��450��6   $	��800��6,   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 	LightCyan��6    � Offset$	 0.0Q�61   � 5      $ LightSkyBlue��6   $	 1.0Q�64   5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� $��0��6   $��Adressverwaltung��6!   $��20(�69   $��10q�6G   �� 5   
   -   5         ��Name$ AdresseSuchen��5      $��1��6   $��10q�6^   6l   �� 5   
   -   5         ��Name$ AdresseHinzufuegen��5   .   $��1��6   $��1��6   $��Hinzufügen��6k   $��10q�6�   6�   �� 5    
   -   5        $ AdresseEditieren��5    .   $��1��6   $��2��6   $��	Editieren��6g   $��10q�6{   6�   �� 5!   
   -   5        $ AdresseLoeschen��5!   .   $��1��6   $��3��6   $��Löschen��6e   $��10q�6w   6�   �� 5#   
   -   5        $��AdresseListe��5#      ���#cdcdcd$��2��6=   $��4��6J   $��10q�6^   	 �� View	 5$      �� 5%      .P�5&      �� $��Kunde��6%   
 �� Width$	
 100��6[    �� DisplayMemberBinding 64   �� *Kunde+6[   �� 5'      $��Strasse��6%   $	
 100��6_    66   �� *	Strasse+6_   �� 5(      $	��PLZ��6%   $	
 100��6W    62   �� *PLZ+6W   �� 5)      $	��Ort��6%   $	
 100��6W    62   �� *Ort+6W   5*      5,      5-      5.      