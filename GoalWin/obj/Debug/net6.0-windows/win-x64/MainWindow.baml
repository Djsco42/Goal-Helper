   M S B A M L   `   `   `  ����B  >GoalWin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GoalWinGoalWin  5   	       GoalWin.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:GoalWin     5   	   -   5          �Name$	  Win��5   	    � Title$ 
MainWindow��5   	   $	��500��6   $	��900��6)   ���	#FFDE7575$	��900��5
   	   $	��500��5   	   .��5      � -   5         �Name$ Ggrid��5      $��	36,36,0,0q�6   $	��270��6-   $	��200��6=   $
��Left=�6L   $	��Top=�6g   $	��242��6   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ GDate��5      $��30��6%   $	��115��61   $��30��6=   $	��115��6L   
���   �$��58,119,52,256q�6�   ��6[   Z� 6�   �� 5   
   -   5         ��Name$
 Gsum��5      $��Summit Goal��6   $��56,296,50,79q�65   ���	#FF1DCA5F$
��Bold"�6z   $��30��6�   $	��120��6�   $��30��6�   $	��120��6�   ��6L   Z� 6�   �� 5   
   -   5         ��Name$ Glable��5      $��Setting Up A Goal��6    $��13,10,13,350q�6<   ���	#FFF34444$
��Bold"�6   $��20(�6�   $��45��6�   $	��200��6�   ��6R   Z� 6�   �� 5   
   -   5         ��Name$
 Grec��5      $��Stretch=�6"   $��Stretch=�6A   ���	#FF1BBCAD K� ZIndex$ -1��6o    �� RadiusX$ 30��6�   	 �� RadiusY$	 30��6�   $��0,0,0,0q�6�   �� 5   
   -   5        
 ��Name$
 Gname��5      $��13,60,13,309q�6!   $��15(�6N   ��67   Z� .��6]   ��5      �� 5       �� 
TargetType" ��6    �� 	Resources 5         WatermarkBrush �� Opacity j� Stretch !� Visual��%�   &	        !� 5      $	 0.5Q�6=   $
 None=�6K    5      �� 5   "   $��Add A Title To Your Goal��6,   $��Italic$�6L   
���   �$��18(�6r   5      5       �� Triggers 5      P� 5        P� Property � �� P� Value$  ��62   . �5!      ��  �� Property � �� �� Value# [  6;   5"      P� 5#       �@J�IsKeyboardFocused$
 True��6?   . �5$      ��  � ��
 �����6;   5%      5'      .��5(      5)      �� 5*   
   -   5        $
 Gnote��5*      $��13,166,13,203q�6!    �� TextWrapping$
 Wrap=�6O   $��15(�6c   ��68   Z� .��6q   ��5+      �� 5,      " ��6    5-      ��%�   &	        !� 5.      $	 0.5Q�6=   $
 none=�6K    5/      �� 50   "   $ ��Extra Notes To Pursue Goal��6,   $��Italic$�6N   
���   �$��18(�6t   $
��Wrap=�6�   52      53       54      P� 55       � ��$  ��62   . �56      ��  � ��# [  6;   57      P� 58       �@J�IsKeyboardFocused$
 True��6?   . �59      ��  � ��
 �����6;   5:      5<      .��5=      5>      �� 5?   
   -	   5        $

 Gpry��5?      $��13,238,13,131q�6    $
 Wrap=�6N   $��15(�6b   ��67   Z� .��6�   ��5@      �� 5A      " ��6    5B      ��%�   &	        !� 5C      $	 0.5Q�6=   $
 none=�6K    5D      �� 5E   "   $!��Add Goal Priority If Needed��6,   $��Italic$�6O   
���   �$��18(�6u   $
��Wrap=�6�   5G      5H       5I      P� 5J       � ��$  ��62   . �5K      ��  � ��# [  6;   5L      P� 5M       �@J�IsKeyboardFocused$
 True��6?   . �5N      ��  � ��
 �����6;   5O      5Q      .��5R      5S      �� 5T   
   -
   5         ��Name$ GInputState��5T      $��Center=�6)   $��	0,350,0,0q�6F   $
��Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��166��6�   $��45��6�   $��15(�6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   &   System.Windows.Controls.DataGrid  5U   
   -   5          Name$ Gcurrent��5U      $��457,0,-516,327q�6%      AutoGenerateColumns$ False��6=      SelectionMode$ Single=�6Y      Columns 5V      0  *System.Windows.Controls.DataGridTextColumn  5W      ,  &System.Windows.Controls.DataGridColumn   Header$ Name Of Goal��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Name+  5X      $ Finish Date��6%    6:   �� *Date+  5Y      $ Helpful Notes��6%    6<   �� *Notes+  5Z      $ Priority��6%    67   �� *Pri+5]      5_      5`      