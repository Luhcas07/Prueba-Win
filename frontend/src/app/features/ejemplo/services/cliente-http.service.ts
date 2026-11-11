import {inject, Injectable} from "@angular/core";
import {HttpClient, HttpParams} from "@angular/common/http";
import {environment} from "../../../../environments/environment";
import {Observable} from "rxjs";
import {ItemEjemplo} from "../models/ejemplo.model";
import {ClienteService} from "./cliente.service";
import {ItemCliente} from "../models/cliente.model";

@Injectable()
export class ClienteHttpService implements ClienteService {
  private readonly http = inject(HttpClient);
  private readonly endpoint = `${environment.apiUrl}/clientes`;

  listar(termino: string, limite: number = 10): Observable<ItemCliente[]> {
    var params = new HttpParams();
    if(termino) {
      params.append('termino', termino);
    }
    if(limite && limite > 0) {
      params.append('limite', limite);
    }
    return this.http.get<ItemCliente[]>(`${this.endpoint}/buscar`, { params });
  }
}
