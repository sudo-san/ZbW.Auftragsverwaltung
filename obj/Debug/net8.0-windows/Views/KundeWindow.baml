   M S B A M L   `   `   `  ����M  IAuftragsverwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AuftragsverwaltungAuftragsverwaltung  5   	   $    Auftragsverwaltung.KundeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Auftragsverwaltung     5   	     � Title$  KundeWindow��5   	   $	��450��6   $	��800��6*   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 	LightCyan��6    � Offset$	 0.0Q�61   � 5      $ LightSkyBlue��6   $	 1.0Q�64   5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� $��0��6   $��Kundenverwaltung��6!   $��20(�69   $��10q�6G   �� 5   
   -   5        $��1��5      $��1��6   $��Hinzufügen��6.   $��10q�6\   6j   �� 5   
   -   5         ��Name$ KundeEditieren��5   .   $��1��6   $��2��6   $��	Editieren��6F   $��10q�6w   6�   �� 5    
   -   5        $ KundeLoeschen��5    .   $��1��6   $��3��6   $��Löschen��6E   $��10q�6s   6�   �� 5"   
   -   5         ��Name$ KundeSuchen��5"      $��1��6   $��10q�6Z   6h   �� 5#   
   -   5        $��
KundeListe��5#      ���#cdcdcd$��2��6;   $��4��6H   $��10q�6\   	 �� View	 5$      �� 5%      .P�5&      �� $��Vorname��6%   
 �� Width$	
 150��6_    �� DisplayMemberBinding 66   �� *	Vorname+6_   �� 5'      $��Nachname��6%   $	
 150��6a    67   �� *
Nachname+6a   �� 5(      $��Email��6%   $	
 150��6Z    64   �� *Mail+6Z   �� 5)      $��Webseite��6%   $	
 150��6`    67   �� *	Website+6`   5*      5,      5-      5.      