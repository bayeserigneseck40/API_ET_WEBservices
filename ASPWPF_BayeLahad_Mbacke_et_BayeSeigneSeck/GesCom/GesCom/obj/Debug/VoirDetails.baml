   M S B A M L   `   `   `  ����A  =GesCom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GesComGesCom  5   	       GesCom.VoirDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:GesCom     5   	   -   5          � Title$  VoirDetails��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   o� $��0��6   $��0��6   $	��450��6,   
������ $��2��5      $��	0,0,47,10q�6)   $��2��6<   .@�5      m� $��	Commandes��6   $��15(�6*   $��Italic$�68    m� Icon 5      �� 5      $��Assets/img_home.png��6   $
��None=�69   $	��100��6H   .@�5      m� -   5        $��Liste Commande��5       5      �� 5      $��Assets/img_home.png��6    $
��None=�6=   $	��100��6L   5      m� 5      -   5        $��Saisir Commande��5       5      �� 5      $��Assets/max_def.png��6    $	��100��6<   $
��None=�6I   5      �� 5      m� 5      -   5        $��Quitter��5       5      �� 5      $��Assets/img_exit.png��6    $	��100��6=   $
��None=�6J   5!      5"      m� 5#      $��Rechercher Commande��6   $��Italic$�65   $��15(�6H    5$      �� 5%      $��Assets/img_search.png��6   $
��None=�6;   $	��200��6J   $��49��6V   .@�5'      m� -   5        $��voir Details��5'       5(      �� 5)      $��Assets/img_folder.png��6    $	��100��6?   $
��None=�6L   5+      m� 5,      -   5        $��Ajouter Commande��5,       5-      �� 5.      $��Assets/max_def.png��6    $	��100��6<   $
��None=�6I   50      51      m� 52      $��Gestion Commande��6   $��15(�62   $��Italic$�6@    53      �� 54      $��Assets/img_about.png��6   $
��None=�6:   $	��100��6I   .@�56      m� -   5        $��Gestion��56       57      �� 58      $��Assets/img_about.png��6    $
��None=�6>   $	��100��6M   5:      m� 5<      -   5        $��Produit��5<       5=      �� 5>      $��Assets/img_about.png��6    $
��None=�6>   $	��100��6M   5@      5A      5C      �� 5D   
   -	   5        $��textCom��5D      $
��Left=�6!   $��	42,28,0,0q�6<    �� TextWrapping$
 Wrap=�6O   $	��Top=�6e   $	��159��6}   $��26(�6�   ���	#FFF6F6F6
������� �� TextAlignment$ Center=�5H      ��5E      Z� 5H      �� 5I   
   -
   5        $��Italic$�5I      $
��Bold"�6%   $��Rechercher ��6J   $
��Left=�6`   $��
206,30,0,0q�6{   $	��Top=�6�   $	��117��6�   
����������	#FF64CCF1$��Arial)�5K      $��20(�5L      $��32��6   &   System.Windows.Controls.DataGrid  5M   
   -   5        $��	dataGrid2��5M      $��10,70,-10,26q�6O    � 	Resources 5N      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%  '        �� 5O      "  6   .�5P      ��  � ��
 � � �63   �� 5Q       � ��$ SemiBold"�63   �� 5R       � ��$ 0,0,1,2q�68   �� 5S       � ��
 �   �64   �� 5T       � ��$ 18(�61   �� 5U       � ��$ 40��6/   5V      5W         Columns 5X      0  *System.Windows.Controls.DataGridTextColumn  5Y      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Order ID��6%   
   FontSize$
 16Q�67      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *	OrderID+6a     5Z      $	 
Product ID��6%   $
 16Q�69   $	 120 6e    6G   �� *	ProductID+6e     5[      $	 	UnitPrice��6%   $
 16Q�68   $	 120 6d    6F   �� *	UnitPrice+6d     5\      $	 Quantity��6%   $
 16Q�67   $	 120 6b    6E   �� *
Quantity+6b     5]      $	 Discount��6%   $
 16Q�67   $	 120 6b    6E   �� *
Discount+6b     5^      $	 ProductName��6%   $
 16Q�6:   $	 120 6h    6H   �� *ProductName+6h   5`      5b      5d      