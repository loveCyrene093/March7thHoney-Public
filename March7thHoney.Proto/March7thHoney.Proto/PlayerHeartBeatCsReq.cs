using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerHeartBeatCsReq : IMessage<PlayerHeartBeatCsReq>, IMessage, IEquatable<PlayerHeartBeatCsReq>, IDeepCloneable<PlayerHeartBeatCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlayerHeartBeatCsReq> _parser = new MessageParser<PlayerHeartBeatCsReq>(() => new PlayerHeartBeatCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ClientTimeMsFieldNumber = 3;

	private ulong clientTimeMs_;

	public const int KKCDCIJHJFAFieldNumber = 9;

	private uint kKCDCIJHJFA_;

	public const int ScDataFieldNumber = 11;

	private DODELEAICGI scData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerHeartBeatCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerHeartBeatCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint KKCDCIJHJFA
	{
		get
		{
			return kKCDCIJHJFA_;
		}
		set
		{
			kKCDCIJHJFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DODELEAICGI ScData
	{
		get
		{
			return scData_;
		}
		set
		{
			scData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerHeartBeatCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerHeartBeatCsReq(PlayerHeartBeatCsReq other)
		: this()
	{
		clientTimeMs_ = other.clientTimeMs_;
		kKCDCIJHJFA_ = other.kKCDCIJHJFA_;
		scData_ = ((other.scData_ != null) ? other.scData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerHeartBeatCsReq Clone()
	{
		return new PlayerHeartBeatCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerHeartBeatCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerHeartBeatCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ClientTimeMs != other.ClientTimeMs)
		{
			return false;
		}
		if (KKCDCIJHJFA != other.KKCDCIJHJFA)
		{
			return false;
		}
		if (!object.Equals(ScData, other.ScData))
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
		if (ClientTimeMs != 0L)
		{
			num ^= ClientTimeMs.GetHashCode();
		}
		if (KKCDCIJHJFA != 0)
		{
			num ^= KKCDCIJHJFA.GetHashCode();
		}
		if (scData_ != null)
		{
			num ^= ScData.GetHashCode();
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
		if (ClientTimeMs != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(ClientTimeMs);
		}
		if (KKCDCIJHJFA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KKCDCIJHJFA);
		}
		if (scData_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(ScData);
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
		if (ClientTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ClientTimeMs);
		}
		if (KKCDCIJHJFA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKCDCIJHJFA);
		}
		if (scData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ScData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerHeartBeatCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ClientTimeMs != 0L)
		{
			ClientTimeMs = other.ClientTimeMs;
		}
		if (other.KKCDCIJHJFA != 0)
		{
			KKCDCIJHJFA = other.KKCDCIJHJFA;
		}
		if (other.scData_ != null)
		{
			if (scData_ == null)
			{
				ScData = new DODELEAICGI();
			}
			ScData.MergeFrom(other.ScData);
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
			case 24u:
				ClientTimeMs = input.ReadUInt64();
				break;
			case 72u:
				KKCDCIJHJFA = input.ReadUInt32();
				break;
			case 90u:
				if (scData_ == null)
				{
					ScData = new DODELEAICGI();
				}
				input.ReadMessage(ScData);
				break;
			}
		}
	}
}
