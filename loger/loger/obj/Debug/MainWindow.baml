   M S B A M L   `   `   `  ����@  <loger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:logerloger  5   	       loger.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:loger     5   	     � Title$  LogIn��5   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�6*   
������  � AllowsTransparency . 
������ $��Center=�6�   $	��400��6�   $	��525��6�   .��5
      ��  �� CornerRadius$ 10��6   $��3q�6   ���	#FF6B80C7._�5   
   � ��5      �� 5       �� ImageSource$ image\bg.jpg��6   .+�5      �� $ 20��6   $��5q�6'   $��1,0,-1,0q�6;   ._�5      � $
��Left=�6   
�������$��36��6K   $	��Top=�6W   $	��513��6o    J� RenderTransformOrigin$ 0.486,-2.783&�6{   $��
-2,-2,-2,0q�6�    � RowDefinitions 5      �� 5      �� 5      $��14 �6(   .+�5      �� $
��Left=�6   $��36��67   $	��Top=�6C   $��48��6[   $ -0.636,-1.927&�6f   $��image/MALL.jpg��6�   $��18,0,0,0q�6�   $��2��6�   $��UniformToFill=�6�   �� 5      $��Center=�6    $��24��6=   $��
ExtraBlack"�6J   $
��Wrap=�6c   $��MACROS��6w   $	��Top=�6�   $	��113��6�   $ 1.882,-3&�6�   $��22(�6�   $��213,-6,191,0q�6�   ��5      
� 5      .��5   "   �  � Color$ 	#FF18EA35��6/   	 � Offset$	 0.874Q�6A   � 5   "   $ 	#FFB40909��6/   $	 0.126Q�6A   � 5   "   $ 	#FFECB94C��6/   $	 0.422Q�6A   � 5   "   $ 	#FFDDF01F��6/   $	 0.587Q�6A   � 5   "   $ 	#FF076DFF��6/   $	 0.213Q�6A   � 5   "   $ 	#FF4E512B��6/   $	 0.713Q�6A   � 5    "   $ 	#FF1D1266��6/   $	 0.043Q�6A   5!      5#      �� 5$      $��Center=�6    $��Heavy"�6=   $��19��6P   $
��Wrap=�6]   $&�� We create, We design, We Develop��6q   $	��Top=�6�   $	��173��6�   $ 0.836,-1.467&�6�   $��180,18,160,-1q�6�   $��Script MT Bold)�6�   $��2��6  ��5%      �� 5&      
 �� EndPoint$
 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��5'   "   � $ Black��6/   $	 0Q�6=   � 5(   "   $ White��6/   $	 1Q�6=   � 5)   "   $ 	#FF1E1532��6/   $	 0.583Q�6A   � 5*   "   $ 	#FF130D20��6/   $	 0.383Q�6A   � 5+   "   $ 	#FF0A8177��6/   $	 0.383Q�6A   � 5,   "   $ 	#FF81083F��6/   $	 0.887Q�6A   � 5-   "   $ 	#FF4D0E38��6/   $
	 0.73Q�6A   � 5.   "   $ 	#FF6F093C��6/   $	 0.835Q�6A   � 5/   "   $ 	#FF07050D��6/   $	 0.161Q�6A   � 50   "   $ 	#FFF1AA11��6/   $	 0.161Q�6A   51      53      A� 54      -   5        ���	#FFE2D018$
��Left=�54   /   $��12��6J   $��
462,10,0,0q�6W   $	��Top=�6k   $��13��6�   $ -7.2,-7.286&�6�   A� 55      -   5        ���	#FFF72B0B$
��Left=�55   /   $��12��6J   $��
487,10,0,0q�6W   $	��Top=�6k   $��13��6�   $ 2.174,0.591&�6�   56      57      � 5<      $
��Left=�6   $	��297��6/   $��
126,76,0,0q�6<   $	��Top=�6P   $	��306��6h   .+�5=      �� $��Center=�6   $��47��69   $
��Wrap=�6F   $��Login��6Z   $	��Top=�6g   $��84��6   $��Script MT Bold)�6�   $��36(�6�   $ 1.405,0.632&�6�   $��109,6,113,0q�6�   
�����_�6�   �� 5>      -   5         ��Name$ UserText��5>      $��2q�6,   $
��Left=�6B   
������ $��36��6w   $��	19,87,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��277��6�   .��6�   ��5?      �� 5@      $
 0.5,1&�6.   $ 0.5,0&�6?   .��5A      � $ Black��6+   $	 0Q�69   � 5B      $ 	#FFCF7E7E��6+   $	 1Q�6=   5C      .��5D   +   ��5E      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5F       �� 6   6sys&clr-namespace:System;assembly=mscorlib     6     �� 
TargetType" ��6T    �� 	Resources 5G         CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%�   &	        !� 5H   "   $
 Left=�6E   $
 None=�6W    5I   &   �� 5J   *   $��Enter name here��60   
�������6c   5L   #   5M       �� Triggers 5N      P� 5O   "    P� Property � �� �� Empty P� Value# Z 6:   . �5P   &   ��  �� Property � �� �� Value# [  6C   6m   5Q   #   P� 5R   "    � �� 6:   Z� . �5S   &   ��  � ��# [  6D   6n   5T   #   P� 5U   "    �@J�IsKeyboardFocused . . �5V   &   ��  � ��
 �����6S   5W   #   5Y      .��5[   %   5\      �� 5]      $
��Left=�6   $��16��68   $��	21,65,0,0q�6D   $
��Wrap=�6W   $��Username��6k   $	��Top=�6{   $��80��6�   $��Arial Black)�6�   
�������6�   �� 5^      $
��Left=�6   $��16��67   $��
21,140,0,0q�6C   $
��Wrap=�6X   $��Password��6l   $	��Top=�6|   $��71��6�   $��Arial Black)�6�   
�������6�   �� 5_      -   5        $ PasswodText��5_      $��2q�6/   $
��Left=�6D   $��36��6_   $��
21,163,0,0q�6k   
������ $
 Wrap=�6�   $	��Top=�6�   $	��277��6�   .��6�   ��5`      �� 5a      $

 0,20&�6.    � MappingMode$ Absolute=�6>   $	 0,0&�6U   .��5b      � $ 	#FFABADB3��6+   $
	 0.05Q�6=   � 5c      $ 	#FFE2E3EA��6+   $
	 0.07Q�6=   � 5d      $ 	#FF0F7AE4��6+   $	 1Q�6=   5e      .��5f   +   5g      �� 5h      $
��Left=�6   $��	ExtraBold"�67   $��26��6N   $��
25,231,0,0q�6Z   $
��Wrap=�6n   $��Login��6�   $	��Top=�6�   $��48��6�   $��20(�6�   $��Script MT Bold)�6�   
�������6�   A� 5i      -   5        ���	#FF28CD3E$
��Left=�5i   +   $��12��6F   $��
85,240,0,0q�6R   $	��Top=�6f   $��13��6~   $ -2.846,0.917&�6�   6�   5k      5m      5n      5p      