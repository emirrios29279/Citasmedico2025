<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bienvenida</title>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@700&display=swap" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" />
    <style>
        /* Estilos súper básicos y directos */
        body {
            font-family: 'Montserrat', sans-serif;
            background-color: #121212; /* Fondo oscuro */
            color: white;
            display: flex;
            justify-content: center;
            align-items: center;
            text-align: center;
            padding: 2rem;
            min-height: 100vh;
        }

        /* Contenedor principal para las 3 tarjetas */
        .card-container {
            display: flex;
            gap: 2rem; /* Espacio entre tarjetas */
            flex-wrap: wrap; /* Para que se vea bien en pantallas pequeñas */
            justify-content: center;
        }

        /* Estilo de cada tarjeta */
        .profile-card {
            background-color: #25a9c8; /* Un solo color para todas, ¡simple! */
            color: #121212;
            padding: 2rem;
            border-radius: 15px;
            width: 280px;
            border: 4px solid white;
        }

        .profile-card i {
            font-size: 3rem; /* Ícono grande y visible */
            margin-bottom: 1rem;
        }
        
        /* Estilo de los botones */
        .btn {
            display: block;
            background-color: white;
            color: #121212;
            padding: 12px;
            margin-top: 1rem;
            border-radius: 8px;
            text-decoration: none;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>BIENVENIDO A FARMACIAS FLAMA VIDA</h1>
            <h2>¿QUÉ DESEA REALIZAR?</h2>
            
            
            <div class="card-container" style="margin-top: 2rem;">

                <div class="profile-card">
                    <i class="fa-solid fa-user"></i>
                    <p>Si eres paciente o cliente, ingresa desde aquí.</p>
                    <a href="#" class="btn">INICIAR SESIÓN</a>
                    <a href="#" class="btn">REGISTRARSE</a>
                </div>

                <div class="profile-card">
                    <i class="fa-solid fa-plus"></i>
                    <p>Si eres personal de la farmacia, ingresa aquí.</p>
                    <a href="#" class="btn">INICIAR SESIÓN</a>
                    <a href="#" class="btn">REGISTRARSE</a>
                </div>

                <div class="profile-card">
                    <i class="fa-solid fa-staff-snake"></i>
                    <p>Si eres un médico asociado, ingresa desde aquí.</p>
                    <a href="#" class="btn">INICIAR SESIÓN</a>
                    <a href="#" class="btn">REGISTRARSE</a>
                </div>

            </div>

        </div>

    </form>

</body>
</html>