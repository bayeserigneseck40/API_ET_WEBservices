   M S B A M L   `   `   `  ����A  =GesCom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GesComGesCom  5   	       GesCom.Produit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:GesCom     5   	     � Title$  Produit��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
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
   -   5          Name$ dataGridProduit��5C         AutoGenerateColumns .  $��
10,55,0,10q�6c    � 	Resources 5D      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%  '        �� 5E      "  6   .�5F      ��  � ��
 � � �63   �� 5G       � ��$ SemiBold"�63   �� 5H       � ��$ 0,0,1,2q�68   �� 5I       � ��
 �   �64   �� 5J       � ��$ 18(�61   �� 5K       � ��$ 40��6/   5L      5M         Columns 5N      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Product ID��6%   
   FontSize$
 16Q�69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *	ProductID+6e     5Q      $	 ProductName��6%   $
 16Q�6:   $	 120 6h    6H   �� *ProductName+6h     5R      $	 QuantityPerUnit��6%   $
 16Q�6>   $	 120 6p    6L   �� *QuantityPerUnit+6p     5S      $	 UnitsInStock��6%   $
 16Q�6;   $	 120 6j    6I   �� *UnitsInStock+6j     5T      $	 	UnitPrice��6%   $
 16Q�68   $	 120 6d    6F   �� *	UnitPrice+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5U         HeaderTemplate 5V      �� 5W      .R�5X      �� $��Action��6(   5Y         CellTemplate 5[      �� 5\      .R�5]      ��  �� Orientation$ 
Horizontal=�6)   .+�5^   "   ��  ��Name$ 	updateBtn��6)   -	   5        $��	COMMANDER��5^   <   $��15(�6e   $��28��6s   
�������$��Arial)�5_   !   5`      5a      5c      5f      5h      5i      