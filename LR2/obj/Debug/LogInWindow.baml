   M S B A M L   `   `   `  ����>  :LR2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LR2LR2  5   	       	LR2.LogIn   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:LR2     5   	     � Title$  LogIn��5   	   $	��230��6   $	��330��6$    � WindowStartupLocation$ CenterOwner=�60    � 	Resources 5	       �� 
TargetType �� Property �� Value �� Triggers :� RoutedEvent �� TargetProperty		 �� To
 g� AutoReverse��%�  '��       �� 5
   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �   �6+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 12(�6)    5      :� 5      $ Mouse.MouseMove��6   [�5      �� 5      .��5      �� .��5   "   �� $ Foreground.Color�61   $
	 PinkX�5   )   
 . 63   5      5      5      5      5      .��5      �� .+�5   
   �� $��АВТОРИЗАЦИЯ��6   $��Center=�6'   $��Center=�6D   $��20q�6_   $��20(�6k   
����i��6y   �� 5    
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5!      �� $��Логин:��6   $��Center=�6&   $
��10,0q�6A   �� 5"      -   5        $��login��5"      $��admin��6#   $��Center=�60   $��Center=�6M   $	��150��6h   $��5q�6t   5#      �� 5$   
   $ 
Horizontal=�6   $��Center=�6.   .+�5%      �� $��Пароль:��6   $��Center=�6'   $	��7,0q�6B   G� 5&      -   5        $��passwd��5&   +    G� Password$ admin��6   $��Center=�69   $��Center=�6V   $	��150��6q   $��5q�6}   5'      �� 5(   
   -   5        $��Вход��5(      $��50��6    $��10q�6+   $��14(�6L   
����i��6Z   �� 5)   
   $ 
Horizontal=�6   $��Center=�6.   .+�5*      �� $3��-Ещё не зарегистрированы?��6   $
��10,5q�68   �� 5+      -   5        $*��$Зарегистрироваться��5+      
������ 
������ 6e   5,      5-      5.      