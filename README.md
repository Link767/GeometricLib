<!--Стиль кнопки-->
    <Style TargetType="Button">
        <Setter Property="Background" Value="{x:Null}"/>
        <Setter Property="FontFamily" Value="Garamond"/>
        <Setter Property="FontSize" Value="20"/>
        <Setter Property="Margin" Value="10"/>
        <Setter Property="Padding" Value="8"/>
        <Setter Property="BorderBrush" Value="Aqua"/>
        <Setter Property="Foreground" Value="#FF0C38CD"/>
    </Style>
    <!--Стиль надписи-->
    <Style x:Key="LabelStyle" TargetType ="Label">
        <Setter Property="FontFamily" Value="Garamond"/>
        <Setter Property="FontSize" Value="20"/>
        <Setter Property="Margin" Value="10"/>
        <Setter Property="Padding" Value="8"/>
        <Setter Property="Foreground" Value="#FF0C38CD"/>
        <Setter Property="VerticalContentAlignment" Value="Center"/>
        <Setter Property="HorizontalContentAlignment" Value="Right"/>
    </Style>
    <Style x:Key="LabelStyle" TargetType ="Label"
           BasedOn="{StaticResource LabelStyle}">
        <Setter Property="FontSize" Value="30"/>
        <Setter Property="FontWeight" Value="ExtraBold"/>
        <Setter Property="HorizontalContentAlignment" Value="Right"/>
    </Style>
    <!--Стиль для поля ввода теста-->
    <Style TargetType="TextBox">
        <Setter Property="FontFamily" Value="Garamond"/>
        <Setter Property="FontSize" Value="20"/>
        <Setter Property="Margin" Value="10"/>
        <Setter Property="Padding" Value="8"/>
        <Setter Property="Foreground" Value="#FF0C38CD"/>
    </Style>
    <Style TargetType="ComboBox">
        <Setter Property="VerticalContentAlignment" Value="Center"/>
        <Setter Property="HorizontalContentAlignment" Value="Left"/>
        <Setter Property="FontFamily" Value="Garamond"/>
        <Setter Property="Margin" Value="10"/>
        <Setter Property="Padding" Value="8"/>
        <Setter Property="Foreground" Value="#FF0C38CD"/>
    </Style>
    <!--Стиль для поля пароля-->
    <Style TargetType="PasswordBox">
        <Setter Property="FontSize" Value="24"/>
        <Setter Property="FontFamily" Value="Garamond"/>
        <Setter Property="Margin" Value="10"/>
        <Setter Property="VerticalContentAlignment" Value="Center"/>
    </Style>
    <Style TargetType="DataGrid">
        <Setter Property="FontSize" Value="20"/>
        <Setter Property="FontFamily" Value="Garamond"/>
        <Setter Property="Margin" Value="10"/>
    </Style>
    <!--Стиль для заголовка списков-->
    <Style TargetType="DataGridColumnHeader">
        <Setter Property="FontSize" Value="20"/>
        <Setter Property="FontFamily" Value="Garamond"/>
        <Setter Property="VerticalContentAlignment" Value="Center"/>
        <Setter Property="HorizontalContentAlignment" Value="Center"/>
        <Setter Property="FontWeight" Value="ExtraBold"/>
    </Style>