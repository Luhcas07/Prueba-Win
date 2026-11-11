import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { mockResponse, MockStore } from '../../../core/mock/mock-api';
import { EjemploService } from './ejemplo.service';
import { ItemEjemplo } from '../models/ejemplo.model';
import {ClienteService} from "./cliente.service";
import {ItemCliente} from "../models/cliente.model";

@Injectable()
export class MockEjemploService implements ClienteService {
  private readonly store = new MockStore<ItemCliente>([
    { id: 1, tipoDocumento: 'DNI', numeroDocumento: '98765432', razonSocial: 'Cliente A', segmento: '', correo: 'cliente1@gmail.com' },
    { id: 2, tipoDocumento: 'RUC', numeroDocumento: '10789456129', razonSocial: 'Cliente B', segmento: '', correo: 'cliente2@gmail.com' },
    { id: 3, tipoDocumento: 'DNI', numeroDocumento: '12345678', razonSocial: 'Cliente C', segmento: '', correo: 'cliente3@gmail.com' }
  ]);

  listar(termino: string, limite: number): Observable<ItemCliente[]> {
    return mockResponse(this.store.all().filter((c) => c.numeroDocumento.startsWith(termino) || c.razonSocial.startsWith(termino)));
  }
}
