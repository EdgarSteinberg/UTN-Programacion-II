using EstructurasLibrary;


NivelBasico basico = new NivelBasico();
NivelTecnico tecnico = new NivelTecnico();
NivelEspecialista especialista = new NivelEspecialista();
ProveedorExterno proveedor = new ProveedorExterno();

basico.SetSiguiente(tecnico);
tecnico.SetSiguiente(especialista);
especialista.SetSiguiente(proveedor);

Solicitud solicitud = new Solicitud("Software", 3);

basico.Atender(solicitud);