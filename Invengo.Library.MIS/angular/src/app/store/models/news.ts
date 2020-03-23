export namespace News {
  export interface State {
    news: Response;
  }

  export interface Response{
    items: News[];
    totalCount: number;
  }

  export interface News{
    type: NewsType,
    title: string,
    author: string,
    editor: string,
    tags: string,
    description: string,
    sourcesName: string,
    sourcesAddress: string,
    releaseTime: string,
    sortCode: number,
    status: Status,
    content: string,
    remark: string,
    tenantId: string,
    isDeleted: boolean,
    deleterId: string,
    deletionTime: string,
    lastModificationTime: string,
    lastModifierId: string,
    creationTime: string,
    creatorId: string,
    id: string
  }

  export enum NewsType{
    Other,
    News,
    Notice,
  }

  export enum Status{
    Draft,
    Release,
  }

}