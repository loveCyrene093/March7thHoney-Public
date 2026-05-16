using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerHeartBeatScRsp : IMessage<PlayerHeartBeatScRsp>, IMessage, IEquatable<PlayerHeartBeatScRsp>, IDeepCloneable<PlayerHeartBeatScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlayerHeartBeatScRsp> _parser = new MessageParser<PlayerHeartBeatScRsp>(() => new PlayerHeartBeatScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DownloadDataFieldNumber = 4;

	private ClientDownloadData downloadData_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int ClientTimeMsFieldNumber = 9;

	private ulong clientTimeMs_;

	public const int ServerTimeMsFieldNumber = 14;

	private ulong serverTimeMs_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerHeartBeatScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerHeartBeatScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientDownloadData DownloadData
	{
		get
		{
			return downloadData_;
		}
		set
		{
			downloadData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong ClientTimeMs
	{
		get
		{
			return clientTimeMs_;
		}
		set
		{
			clientTimeMs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong ServerTimeMs
	{
		get
		{
			return serverTimeMs_;
		}
		set
		{
			serverTimeMs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerHeartBeatScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerHeartBeatScRsp(PlayerHeartBeatScRsp other)
		: this()
	{
		downloadData_ = ((other.downloadData_ != null) ? other.downloadData_.Clone() : null);
		retcode_ = other.retcode_;
		clientTimeMs_ = other.clientTimeMs_;
		serverTimeMs_ = other.serverTimeMs_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerHeartBeatScRsp Clone()
	{
		return new PlayerHeartBeatScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerHeartBeatScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerHeartBeatScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DownloadData, other.DownloadData))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ClientTimeMs != other.ClientTimeMs)
		{
			return false;
		}
		if (ServerTimeMs != other.ServerTimeMs)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (downloadData_ != null)
		{
			num ^= DownloadData.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ClientTimeMs != 0L)
		{
			num ^= ClientTimeMs.GetHashCode();
		}
		if (ServerTimeMs != 0L)
		{
			num ^= ServerTimeMs.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (downloadData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(DownloadData);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (ClientTimeMs != 0L)
		{
			output.WriteRawTag(72);
			output.WriteUInt64(ClientTimeMs);
		}
		if (ServerTimeMs != 0L)
		{
			output.WriteRawTag(112);
			output.WriteUInt64(ServerTimeMs);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (downloadData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DownloadData);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ClientTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ClientTimeMs);
		}
		if (ServerTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ServerTimeMs);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerHeartBeatScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.downloadData_ != null)
		{
			if (downloadData_ == null)
			{
				DownloadData = new ClientDownloadData();
			}
			DownloadData.MergeFrom(other.DownloadData);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.ClientTimeMs != 0L)
		{
			ClientTimeMs = other.ClientTimeMs;
		}
		if (other.ServerTimeMs != 0L)
		{
			ServerTimeMs = other.ServerTimeMs;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 34u:
				if (downloadData_ == null)
				{
					DownloadData = new ClientDownloadData();
				}
				input.ReadMessage(DownloadData);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				ClientTimeMs = input.ReadUInt64();
				break;
			case 112u:
				ServerTimeMs = input.ReadUInt64();
				break;
			}
		}
	}
}
