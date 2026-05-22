using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournEnterRoomCsReq : IMessage<RogueTournEnterRoomCsReq>, IMessage, IEquatable<RogueTournEnterRoomCsReq>, IDeepCloneable<RogueTournEnterRoomCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournEnterRoomCsReq> _parser = new MessageParser<RogueTournEnterRoomCsReq>(() => new RogueTournEnterRoomCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MNMAFKLOJCCFieldNumber = 8;

	private uint mNMAFKLOJCC_;

	public const int LNODOJOOPBKFieldNumber = 12;

	private uint lNODOJOOPBK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournEnterRoomCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournEnterRoomCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RogueTournEnterRoomCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnterRoomCsReq(RogueTournEnterRoomCsReq other)
		: this()
	{
		mNMAFKLOJCC_ = other.mNMAFKLOJCC_;
		lNODOJOOPBK_ = other.lNODOJOOPBK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnterRoomCsReq Clone()
	{
		return new RogueTournEnterRoomCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournEnterRoomCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournEnterRoomCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MNMAFKLOJCC != other.MNMAFKLOJCC)
		{
			return false;
		}
		if (LNODOJOOPBK != other.LNODOJOOPBK)
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
		if (MNMAFKLOJCC != 0)
		{
			num ^= MNMAFKLOJCC.GetHashCode();
		}
		if (LNODOJOOPBK != 0)
		{
			num ^= LNODOJOOPBK.GetHashCode();
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
		if (MNMAFKLOJCC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MNMAFKLOJCC);
		}
		if (LNODOJOOPBK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LNODOJOOPBK);
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
		if (MNMAFKLOJCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNMAFKLOJCC);
		}
		if (LNODOJOOPBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNODOJOOPBK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournEnterRoomCsReq other)
	{
		if (other != null)
		{
			if (other.MNMAFKLOJCC != 0)
			{
				MNMAFKLOJCC = other.MNMAFKLOJCC;
			}
			if (other.LNODOJOOPBK != 0)
			{
				LNODOJOOPBK = other.LNODOJOOPBK;
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
			case 64u:
				MNMAFKLOJCC = input.ReadUInt32();
				break;
			case 96u:
				LNODOJOOPBK = input.ReadUInt32();
				break;
			}
		}
	}
}
