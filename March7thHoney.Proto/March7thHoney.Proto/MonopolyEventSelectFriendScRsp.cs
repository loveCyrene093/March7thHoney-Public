using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyEventSelectFriendScRsp : IMessage<MonopolyEventSelectFriendScRsp>, IMessage, IEquatable<MonopolyEventSelectFriendScRsp>, IDeepCloneable<MonopolyEventSelectFriendScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyEventSelectFriendScRsp> _parser = new MessageParser<MonopolyEventSelectFriendScRsp>(() => new MonopolyEventSelectFriendScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DHLDKLMPHNGFieldNumber = 2;

	private uint dHLDKLMPHNG_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int LJHDOFBFNJHFieldNumber = 11;

	private AAHBECICOEN lJHDOFBFNJH_;

	public const int LMIICENMOBIFieldNumber = 13;

	private uint lMIICENMOBI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyEventSelectFriendScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyEventSelectFriendScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHLDKLMPHNG
	{
		get
		{
			return dHLDKLMPHNG_;
		}
		set
		{
			dHLDKLMPHNG_ = value;
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
	public AAHBECICOEN LJHDOFBFNJH
	{
		get
		{
			return lJHDOFBFNJH_;
		}
		set
		{
			lJHDOFBFNJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMIICENMOBI
	{
		get
		{
			return lMIICENMOBI_;
		}
		set
		{
			lMIICENMOBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventSelectFriendScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventSelectFriendScRsp(MonopolyEventSelectFriendScRsp other)
		: this()
	{
		dHLDKLMPHNG_ = other.dHLDKLMPHNG_;
		retcode_ = other.retcode_;
		lJHDOFBFNJH_ = ((other.lJHDOFBFNJH_ != null) ? other.lJHDOFBFNJH_.Clone() : null);
		lMIICENMOBI_ = other.lMIICENMOBI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventSelectFriendScRsp Clone()
	{
		return new MonopolyEventSelectFriendScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyEventSelectFriendScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyEventSelectFriendScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DHLDKLMPHNG != other.DHLDKLMPHNG)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(LJHDOFBFNJH, other.LJHDOFBFNJH))
		{
			return false;
		}
		if (LMIICENMOBI != other.LMIICENMOBI)
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
		if (DHLDKLMPHNG != 0)
		{
			num ^= DHLDKLMPHNG.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (lJHDOFBFNJH_ != null)
		{
			num ^= LJHDOFBFNJH.GetHashCode();
		}
		if (LMIICENMOBI != 0)
		{
			num ^= LMIICENMOBI.GetHashCode();
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
		if (DHLDKLMPHNG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DHLDKLMPHNG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (lJHDOFBFNJH_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(LJHDOFBFNJH);
		}
		if (LMIICENMOBI != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LMIICENMOBI);
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
		if (DHLDKLMPHNG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHLDKLMPHNG);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (lJHDOFBFNJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJHDOFBFNJH);
		}
		if (LMIICENMOBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMIICENMOBI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyEventSelectFriendScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DHLDKLMPHNG != 0)
		{
			DHLDKLMPHNG = other.DHLDKLMPHNG;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.lJHDOFBFNJH_ != null)
		{
			if (lJHDOFBFNJH_ == null)
			{
				LJHDOFBFNJH = new AAHBECICOEN();
			}
			LJHDOFBFNJH.MergeFrom(other.LJHDOFBFNJH);
		}
		if (other.LMIICENMOBI != 0)
		{
			LMIICENMOBI = other.LMIICENMOBI;
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
			case 16u:
				DHLDKLMPHNG = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (lJHDOFBFNJH_ == null)
				{
					LJHDOFBFNJH = new AAHBECICOEN();
				}
				input.ReadMessage(LJHDOFBFNJH);
				break;
			case 104u:
				LMIICENMOBI = input.ReadUInt32();
				break;
			}
		}
	}
}
