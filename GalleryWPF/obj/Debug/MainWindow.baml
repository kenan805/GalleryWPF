   M S B A M L   `   `   `  ����E  AGalleryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GalleryWPF
GalleryWPF  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 60       GalleryWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GalleryWPF     5   	   6sys&clr-namespace:System;assembly=mscorlib     60   -   5        $��
mainWindow��5        � Title$  Gallery��6	   $	��350��6+   $	��200��6;   $	��450��6J   $	��600��6W    � 	Resources 5	         imgSize��%%   &	        X�5
   
   150Q�6*   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��20* �6   .+�5   
   o� 
�������.@�5      m� $
��File��6   .@�5      m� $	��New��6   m� 5      $
��Open��6   m� 5      $
��Save��6   m� 5      $��Save as��6   m� 5      -   5        $
��Exit��5      6)   5      m� 5      $
��Edit��6   .@�5      m� -   5        $��Add file��5      6-   m� 5      $��
Add folder��6   5      m� 5      $
��View��6   .@�5      m� -   5        $��Small icons��5      60   m� 5       -   5        $��Medium icons��5       61   m� 5!      -   5        $��Large icons��5!      60   5"      m� 5#      $��About��6   5$      �� 5%   
   
�������$	��0.5��6!   	 �� Y1$ 19��6i   	 �� Y2$ 19��6q   	 �� X1 67   ��  �� ElementName$ 
mainWindow�� �� Path$ Width�6q   � 5'   
   $��1��6   .+�5(      �� -   5         ��Name$ listViewImages��5(   g   	 J� 	AllowDrop	 . $��0q�6�   $��Disabled=�6�   
 � IsSharedSizeScope
 . ��6�   �� *Images+��5)      �� 5*      .R�5+      � $	��grh��6$    � Orientation$ 
Horizontal=�6/   6J   5,      ��5/      �� 50      .R�51      � #���   6   #���   6B   .+�52      ��  ��Name$	 img��60   $��10q�6$   $
��Fill=�6=   ��6L   �� *	ImagePath+53      54      56       � 57      -   5          �Name$ 
ImageFrame��57      58      5:      5;      