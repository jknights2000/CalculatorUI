   M S B A M L   `   `   `  ����G  CCalculatorUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CalculatorUICalculatorUI  5   	       CalculatorUI.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CalculatorUI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��	0,10,10,0q�6   .+�5
   
   �� -   5        $��	Calculate��5
      $
��Left=�6%   $��
34,303,0,0q�6R   $	��Top=�6f   $��27��6~   $	��276��6�   �� 5   
   -   5        $��Output��5      $�� ��6   $
��Left=�6)   $��
34,335,0,0q�6D   $	��Top=�6X   $��59��6p   $	��308��6|   $��30(�6�   �� 5   
   -   5        $��NumberOutput��5      $�� ��6   $
��Left=�60   $��
14,111,0,0q�6K   $	��Top=�6_   $��60��6w   $	��490��6�    J� RenderTransformOrigin$ 0.504,0.392&�6�   $��30(�6�   �� 5   
   -   5        $��Operator��5   .   $
��Left=�6   $��
136,81,0,0q�6>   $	��Top=�6R   $	��120��6j   .@�5      �� $��+��6    �� 
IsSelected$
 True��6'   6;   �� 5      $��-��6   6)   �� 5      $��/��6   6)   �� 5      $��*��6   6)   5      �� 5   
   -   5        $��1��5      $
��Left=�6   $��
99,176,0,0q�6P   $	��Top=�6d   $��27��6|   $��37��6�   �� 5   
   -   5        $��2��5      $
��Left=�6   $��160,176,0,0q�6P   $	��Top=�6e   $��27��6}   $��38��6�   �� 5   
   -   5        $��3��5      $
��Left=�6   $��219,176,0,0q�6P   $	��Top=�6e   $��27��6}   $��37��6�   �� 5   
   -   5        $��4��5      $
��Left=�6   $��
99,209,0,0q�6P   $	��Top=�6d   $��27��6|   $��37��6�   �� 5   
   -	   5        $��5��5      $
��Left=�6   $��160,209,0,0q�6P   $	��Top=�6e   $��27��6}   $��37��6�   �� 5   
   -
   5        $��6��5      $
��Left=�6   $��219,209,0,0q�6P   $	��Top=�6e   $��27��6}   $��37��6�   �� 5   
   -   5        $��7��5      $
��Left=�6   $��
99,246,0,0q�6P   $	��Top=�6d   $��27��6|   $��37��6�   �� 5   
   -   5        $��8��5      $
��Left=�6   $��160,250,0,0q�6P   $	��Top=�6e   $��27��6}   $��36��6�   �� 5   
   -   5        $��9��5      $
��Left=�6   $��219,250,0,0q�6P   $	��Top=�6e   $��27��6}   $��37��6�   �� 5   
   -   5        $��0��5      $
��Left=�6   $��
34,176,0,0q�6P   $	��Top=�6d   $	��102��6|   $��37��6�   �� 5   
   -   5        $��Enter��5      $
��Left=�6!   $��289,250,0,0q�6J   $	��Top=�6_   $��28��6w   $	��106��6�   &   System.Windows.Controls.Calendar  5   
   -   5        $	��Cal��5      $
��Left=�6   $��528,130,0,0q�6:   $	��Top=�6O   6g   �� 5   
   -   5        $��	DaysToAdd��5      $
��Left=�6G   $��
558,92,0,0q�6b   $�� ��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5    
   -   5        $
��Date��5       $��No Date Selected��6   $
��Left=�67   $��395,312,0,0q�6R   $	��Top=�6h   $	��339��6�   $	��102��6�   $��20(�6�   5#      5$      