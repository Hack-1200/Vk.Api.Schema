﻿using System.Collections.Generic;
using Vk.Api.Schema.Enums.Poll;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Parameters.Poll
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для polls.getVoters <para/>
    /// Документация: <see href="https://vk.com/dev/polls.getVoters"/>
    /// </summary>
    public interface IPollGetVotersParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, которому принадлежит опрос
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор опроса
        /// </summary>
        int PollId { get; set; }

        /// <summary>
        /// Идентификаторы вариантов ответа
        /// </summary>
        IEnumerable<int> AnswerIds { get; set; }

        /// <summary>
        /// Определяет находится ли опрос в обсуждении или прикреплён к стене
        /// </summary>
        PollBoardType Board { get; set; }

        /// <summary>
        /// указывает, необходимо ли возвращать только пользователей, которые являются друзьями текущего пользователя
        /// </summary>
        /// <remarks>
        /// Необязателен, если не был задан используется <see langword="false"/>
        /// </remarks>
        bool? FriendsOnly { get; set; }

        /// <summary>
        /// Cмещение относительно начала списка, для выборки определенного подмножества
        /// </summary>
        /// <remarks>
        /// Необязателен, если не был задан используется 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Количество возвращаемых идентификаторов пользователей
        /// </summary>
        /// <remarks>
        /// Необязателен, если не был задан используется 100,
        /// если не задан параметр friends_only, в противном случае 10.
        /// Максимальное значение параметра 1000, если не задан параметр friends_only,
        /// в противном случае 100. 
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Поля анкет, необходимые для получения
        /// </summary>
        NameCaseType Fields { get; set; }

        /// <summary>
        /// Падеж для склонения имени и фамилии пользователя
        /// </summary>
        NameCaseType NameCase { get; set; }
    }
}
