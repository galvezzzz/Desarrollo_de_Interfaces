   M S B A M L   `   `   `  ����I  EComienzoConWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ComienzoConWPFComienzoConWPF  5   	       ComienzoConWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ComienzoConWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   #��z��61   #��z��6[   $��5q�6�   $
 30��6�   ._�5)      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      �  J� RenderTransformOrigin$ 
0.471,0.48&�6   .+�5C   
   �� #��� 
 6   $��Aceptar��69   $
��Left=�6K   $��222,191,0,0q�6f   $	��Top=�6{   $��71��6�   $	��165��6�   $ 0.5,1&�6�   ���	#FF00FF04
���   �$��16(�6�   $��Miriam Mono CLM)�6  $
��Bold"�6  ��5D      �� 5E       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67    �� RelativeTransform 5F      V� 5G      .~�5H      ��  �� CenterX$	 0.5Q�6-    �� CenterY$	 0.5Q�6;   �� 5I       �� CenterX$	 0.5Q�6,    �� CenterY$	 0.5Q�6:   �� 5J       �� CenterY$	 0.5Q�6.    �� CenterX$	 0.5Q�6<   T� 5K      5L      .��5N      �  � Color$ 	#FF3EEF00��6#   � 5O      $ 	#FFBCFF13��6#    � Offset$ 1Q�65   5P      z�5R      V� 5S      .~�5T      �� �� 5U      T� 5V      5W      5Y      �� 5Z   
   $��CheckBox��6   $
��Left=�6&   $��26��6A   $��490,214,0,0q�6M   $	��Top=�6b   $	��148��6z   $!��Frank Ruehl CLM BoldOblique)�6�   $��24(�6�   ��5[      �� 5\       �� ImageSource$ /descarga.jpg��6   ��5^      �� 5_      $ 0.5,1&�6&   $ 0.5,0&�67   .��5`      � $ 	#FF848484��6#   � 5a      $ White��6#   $ 1Q�61   5b      5d      5f      5g      