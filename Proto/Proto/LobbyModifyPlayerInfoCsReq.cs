using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyModifyPlayerInfoCsReq : IMessage<LobbyModifyPlayerInfoCsReq>, IMessage, IEquatable<LobbyModifyPlayerInfoCsReq>, IDeepCloneable<LobbyModifyPlayerInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<LobbyModifyPlayerInfoCsReq> _parser = new MessageParser<LobbyModifyPlayerInfoCsReq>(() => new LobbyModifyPlayerInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JHCJMKDDNNFFieldNumber = 6;

	private LobbyGameExtInfo jHCJMKDDNNF_;

	public const int TypeFieldNumber = 10;

	private LobbyModifyType type_;

	public const int GCIIBHHMPNPFieldNumber = 14;

	private uint gCIIBHHMPNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyModifyPlayerInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyModifyPlayerInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGameExtInfo JHCJMKDDNNF
	{
		get
		{
			return jHCJMKDDNNF_;
		}
		set
		{
			jHCJMKDDNNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyModifyType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCIIBHHMPNP
	{
		get
		{
			return gCIIBHHMPNP_;
		}
		set
		{
			gCIIBHHMPNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyModifyPlayerInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyModifyPlayerInfoCsReq(LobbyModifyPlayerInfoCsReq other)
		: this()
	{
		jHCJMKDDNNF_ = ((other.jHCJMKDDNNF_ != null) ? other.jHCJMKDDNNF_.Clone() : null);
		type_ = other.type_;
		gCIIBHHMPNP_ = other.gCIIBHHMPNP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyModifyPlayerInfoCsReq Clone()
	{
		return new LobbyModifyPlayerInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyModifyPlayerInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyModifyPlayerInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JHCJMKDDNNF, other.JHCJMKDDNNF))
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (GCIIBHHMPNP != other.GCIIBHHMPNP)
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
		if (jHCJMKDDNNF_ != null)
		{
			num ^= JHCJMKDDNNF.GetHashCode();
		}
		if (Type != LobbyModifyType.BmdnbhhicldPcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		if (GCIIBHHMPNP != 0)
		{
			num ^= GCIIBHHMPNP.GetHashCode();
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
		if (jHCJMKDDNNF_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(JHCJMKDDNNF);
		}
		if (Type != LobbyModifyType.BmdnbhhicldPcpdhelpkem)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)Type);
		}
		if (GCIIBHHMPNP != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GCIIBHHMPNP);
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
		if (jHCJMKDDNNF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHCJMKDDNNF);
		}
		if (Type != LobbyModifyType.BmdnbhhicldPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (GCIIBHHMPNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCIIBHHMPNP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyModifyPlayerInfoCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jHCJMKDDNNF_ != null)
		{
			if (jHCJMKDDNNF_ == null)
			{
				JHCJMKDDNNF = new LobbyGameExtInfo();
			}
			JHCJMKDDNNF.MergeFrom(other.JHCJMKDDNNF);
		}
		if (other.Type != LobbyModifyType.BmdnbhhicldPcpdhelpkem)
		{
			Type = other.Type;
		}
		if (other.GCIIBHHMPNP != 0)
		{
			GCIIBHHMPNP = other.GCIIBHHMPNP;
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
			case 50u:
				if (jHCJMKDDNNF_ == null)
				{
					JHCJMKDDNNF = new LobbyGameExtInfo();
				}
				input.ReadMessage(JHCJMKDDNNF);
				break;
			case 80u:
				Type = (LobbyModifyType)input.ReadEnum();
				break;
			case 112u:
				GCIIBHHMPNP = input.ReadUInt32();
				break;
			}
		}
	}
}
