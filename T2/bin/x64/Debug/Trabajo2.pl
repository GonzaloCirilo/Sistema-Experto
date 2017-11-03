:- dynamic pertenece_distrito/2.
:- dynamic siguiente_avenida/2.
:- dynamic siguiente_distrito/2.
:- dynamic tipo_De_pasaje/3.

%Avenidas y Distritos

pertenece_distrito(principal, chorrillos).
pertenece_distrito(santa_anita, chorrillos).
pertenece_distrito(huaylas, chorrillos).
pertenece_distrito(chorrillos,chorrillos).
pertenece_distrito(lima,barranco).
pertenece_distrito(miranda, barranco).
pertenece_distrito('republica de panama', miraflores).
pertenece_distrito(aramburu, surquillo).
pertenece_distrito('guardia civil', 'san borja').
pertenece_distrito(aviacion, 'la victoria').
pertenece_distrito(mexico, 'la victoria').
pertenece_distrito('riva aguero', 'la victoria').

%Orden de las Avenidas

siguiente_avenida(principal, 'santa anita').
siguiente_avenida('santa anita', huaylas).
siguiente_avenida(huaylas,chorrillos).
siguiente_avenida(chorrillos,lima).
siguiente_avenida(lima,miranda).
siguiente_avenida(miranda, 'republica de panama').
siguiente_avenida('republica de panama', aramburu).
siguiente_avenida(aramburu, 'guardia civil').
siguiente_avenida('guardia civil', aviacion).
siguiente_avenida(aviacion, mexico).
siguiente_avenida(mexico, 'riva aguero').

%Orden de los Distritos

siguiente_distrito(chorrillos, barranco).
siguiente_distrito(barranco,miraflores).
siguiente_distrito(miraflores,surquillo).
siguiente_distrito(surquillo, 'san borja').
siguiente_distrito('san borja', 'la victoria').

%Tarifa

tipo_De_pasaje(adulto, urbano, 2).
tipo_De_pasaje(adulto, interurbano, 2.50).
tipo_De_pasaje(adulto, directo, 3).
tipo_De_pasaje(medio, urbano, 1).
tipo_De_pasaje(medio, interurbano, 1.20).
tipo_De_pasaje(medio, directo, 1.50).
tipo_De_pasaje(escolar, urbano, 0.5).
tipo_De_pasaje(escolar,interurbano,0.5).
tipo_De_pasaje(escolar, directo, 0.5).

%Regla de Inferencia
es_urbano(Inicio, Fin):-
pertenece_distrito(Inicio, Dist1),
pertenece_distrito(Fin, Dist2),
Dist1 = Dist2.
es_interurbano(Inicio, Fin):-
pertenece_distrito(Inicio, Dist1),
pertenece_distrito(Fin, Dist2),
Dist1\=Dist2.
es_zonal(Inicio, Fin):-
siguiente_avenida(Inicio,Fin).
es_directo(Inicio, Fin):-
siguiente_avenida(_,Inicio),
siguiente_avenida(Fin,_).

%Pago a realizar
pagar(Tipo,Inicio,Fin):-
(es_zonal(Inicio,Fin) -> P=1;
es_urbano(Inicio,Fin) -> tipo_De_pasaje(Tipo,urbano,P);
es_interurbano(Inicio,Fin) ->tipo_De_pasaje(Tipo,interurbano,P);
es_directo(Inicio,Fin)->tipo_De_pasaje(Tipo,directo,P)),
write("El tryecto para "),write(Tipo),write(" desde "), write(Inicio), write(" hasta "),
 write(Fin), write(" cuesta: "),write(P).