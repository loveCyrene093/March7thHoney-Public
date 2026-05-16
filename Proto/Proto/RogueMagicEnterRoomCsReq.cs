using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicEnterRoomCsReq : IMessage<RogueMagicEnterRoomCsReq>, IMessage, IEquatable<RogueMagicEnterRoomCsReq>, IDeepCloneable<RogueMagicEnterRoomCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicEnterRoomCsReq> _parser = new MessageParser<RogueMagicEnterRoomCsReq>(() => new RogueMagicEnterRoomCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LNODOJOOPBKFieldNumber = 7;

	private uint lNODOJOOPBK_;

	public const int MNMAFKLOJCCFieldNumber = 9;

	private uint mNMAFKLOJCC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicEnterRoomCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicEnterRoomCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LNODOJOOPBK
	{
		get
		{
			return lNODOJOOPBK_;
		}
		set
		{
			lNODOJOOPBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MNMAFKLOJCC
	{
		get
		{
			return mNMAFKLOJCC_;
		}
		set
		{
			mNMAFKLOJCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicEnterRoomCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicEnterRoomCsReq(RogueMagicEnterRoomCsReq other)
		: this()
	{
		lNODOJOOPBK_ = other.lNODOJOOPBK_;
		mNMAFKLOJCC_ = other.mNMAFKLOJCC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicEnterRoomCsReq Clone()
	{
		return new RogueMagicEnterRoomCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicEnterRoomCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicEnterRoomCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LNODOJOOPBK != other.LNODOJOOPBK)
		{
			return false;
		}
		if (MNMAFKLOJCC != other.MNMAFKLOJCC)
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
		if (LNODOJOOPBK != 0)
		{
			num ^= LNODOJOOPBK.GetHashCode();
		}
		if (MNMAFKLOJCC != 0)
		{
			num ^= MNMAFKLOJCC.GetHashCode();
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
		if (LNODOJOOPBK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LNODOJOOPBK);
		}
		if (MNMAFKLOJCC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(MNMAFKLOJCC);
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
		if (LNODOJOOPBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNODOJOOPBK);
		}
		if (MNMAFKLOJCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNMAFKLOJCC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicEnterRoomCsReq other)
	{
		if (other != null)
		{
			if (other.LNODOJOOPBK != 0)
			{
				LNODOJOOPBK = other.LNODOJOOPBK;
			}
			if (other.MNMAFKLOJCC != 0)
			{
				MNMAFKLOJCC = other.MNMAFKLOJCC;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 56u:
				LNODOJOOPBK = input.ReadUInt32();
				break;
			case 72u:
				MNMAFKLOJCC = input.ReadUInt32();
				break;
			}
		}
	}
}
