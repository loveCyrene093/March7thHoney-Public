using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyJoinCsReq : IMessage<LobbyJoinCsReq>, IMessage, IEquatable<LobbyJoinCsReq>, IDeepCloneable<LobbyJoinCsReq>, IBufferMessage
{
	private static readonly MessageParser<LobbyJoinCsReq> _parser = new MessageParser<LobbyJoinCsReq>(() => new LobbyJoinCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JHCJMKDDNNFFieldNumber = 5;

	private LobbyGameExtInfo jHCJMKDDNNF_;

	public const int GFFIMGEKDNLFieldNumber = 6;

	private string gFFIMGEKDNL_ = "";

	public const int RoomIdFieldNumber = 7;

	private ulong roomId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyJoinCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyJoinCsReqReflection.Descriptor.MessageTypes[0];

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
	public string GFFIMGEKDNL
	{
		get
		{
			return gFFIMGEKDNL_;
		}
		set
		{
			gFFIMGEKDNL_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyJoinCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyJoinCsReq(LobbyJoinCsReq other)
		: this()
	{
		jHCJMKDDNNF_ = ((other.jHCJMKDDNNF_ != null) ? other.jHCJMKDDNNF_.Clone() : null);
		gFFIMGEKDNL_ = other.gFFIMGEKDNL_;
		roomId_ = other.roomId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyJoinCsReq Clone()
	{
		return new LobbyJoinCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyJoinCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyJoinCsReq other)
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
		if (GFFIMGEKDNL != other.GFFIMGEKDNL)
		{
			return false;
		}
		if (RoomId != other.RoomId)
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
		if (GFFIMGEKDNL.Length != 0)
		{
			num ^= GFFIMGEKDNL.GetHashCode();
		}
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
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
			output.WriteRawTag(42);
			output.WriteMessage(JHCJMKDDNNF);
		}
		if (GFFIMGEKDNL.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(GFFIMGEKDNL);
		}
		if (RoomId != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(RoomId);
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
		if (GFFIMGEKDNL.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GFFIMGEKDNL);
		}
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyJoinCsReq other)
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
		if (other.GFFIMGEKDNL.Length != 0)
		{
			GFFIMGEKDNL = other.GFFIMGEKDNL;
		}
		if (other.RoomId != 0L)
		{
			RoomId = other.RoomId;
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
			case 42u:
				if (jHCJMKDDNNF_ == null)
				{
					JHCJMKDDNNF = new LobbyGameExtInfo();
				}
				input.ReadMessage(JHCJMKDDNNF);
				break;
			case 50u:
				GFFIMGEKDNL = input.ReadString();
				break;
			case 56u:
				RoomId = input.ReadUInt64();
				break;
			}
		}
	}
}
