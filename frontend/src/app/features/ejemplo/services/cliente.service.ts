import {ItemEjemplo} from "../models/ejemplo.model";
import { InjectionToken } from '@angular/core';
import { Observable } from 'rxjs';
import {ItemCliente} from "../models/cliente.model";

export interface ClienteService {
  listar(termino: string, limite: number): Observable<ItemCliente[]>;
}

export const CLIENTE_SERVICE = new InjectionToken<ClienteService>('CLIENTE_SERVICE');
