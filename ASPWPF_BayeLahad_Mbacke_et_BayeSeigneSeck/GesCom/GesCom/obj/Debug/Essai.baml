   M S B A M L   `   `   `  ����A  =GesCom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GesComGesCom  5   	       GesCom.Essai   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:GesCom     5   	     � Title$  Essai��5   	   $	��450��6   $	��800��6$   .��5	      � .+�5
   
   o� $��0��6   $��0��6   $	��450��6,   
������ $��2��5      $��	0,0,47,10q�6)   $��2��6<   .@�5      m� $��	Commandes��6   $��15(�6*   $��Italic$�68    m� Icon 5      �� 5      $��Assets/img_home.png��6   $
��None=�69   $	��100��6H   .@�5      m� -   5        $��Liste Commande��5       5      �� 5      $��Assets/img_home.png��6    $
��None=�6=   $	��100��6L   5      m� 5      -   5        $��Saisir Commande��5       5      �� 5      $��Assets/max_def.png��6    $	��100��6<   $
��None=�6I   5      �� 5      m� 5      -   5        $��Quitter��5       5      �� 5      $��Assets/img_exit.png��6    $	��100��6=   $
��None=�6J   5!      5"      m� 5#      $��Rechercher Commande��6   $��Italic$�65   $��15(�6H    5$      �� 5%      $��Assets/img_search.png��6   $
��None=�6;   $	��200��6J   $��49��6V   .@�5'      m� -   5        $��voir Details��5'       5(      �� 5)      $��Assets/img_folder.png��6    $	��100��6?   $
��None=�6L   5+      m� 5,      -   5        $��Ajouter Commande��5,       5-      �� 5.      $��Assets/max_def.png��6    $	��100��6<   $
��None=�6I   50      51      m� 52      $��Gestion Commande��6   $��15(�62   $��Italic$�6@    53      �� 54      $��Assets/img_about.png��6   $
��None=�6:   $	��100��6I   .@�56      m� -   5        $��Gestion��56       57      �� 58      $��Assets/img_about.png��6    $
��None=�6>   $	��100��6M   5:      m� 5<      -   5        $��Produit��5<       5=      �� 5>      $��Assets/img_about.png��6    $
��None=�6>   $	��100��6M   5@      5A      5B      &   System.Windows.Controls.DataGrid  5C   
   -   5          Name$ 
myDataGrid��5C         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6\   $��
0,42,0,-42q�6l    � 	Resources 5D      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%  '        �� 5E      "  6   .�5F      ��  � ��
 � � �63   �� 5G       � ��$ SemiBold"�63   �� 5H       � ��$ 0,0,1,2q�68   �� 5I       � ��
 �   �64   �� 5J       � ��$ 40��6/   �� 5K       � ��$ 16(�61   5L      5M      	   Columns	 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn
   Header$
 OrderID��6%      FontSize$ 15Q�66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	OrderID+  5P      $
 	ProductID��6%   $ 15Q�68    6F   �� *	ProductID+  5Q      $
 Quantity��6%   $ 15Q�67    6E   �� *
Quantity+  5R      $
 	UnitPrice��6%   $ 15Q�68    6F   �� *	UnitPrice+4  .System.Windows.Controls.DataGridTemplateColumn  5S         HeaderTemplate 5T      �� 5U      .R�5V      �� $��action��6(   5W         CellTemplate 5Y      �� 5Z      .R�5[      ��  �� Orientation$ 
Horizontal=�6)   .+�5b   "   ��  ��Name$ 	updatebtn��6]   -	   5        $��15(�5b   )   $��Italic$�67   $
��Bold"�6J   ��6�   Z� .��5d   &   �� $��Assets/edit.png��6,   $
��None=�6E   $	��100��6T   5e   #   �� 5g   "   $ 	deletebtn��6]   -
   5        $��15(�5g   )   $��Italic$�67   $
��Bold"�6J   ��6�   Z� .��5h   +   �� $��Assets/delete.png��61   $
��None=�6L   $	��100��6[   5j   #   5l      5m      5o      5q      5s      5t      