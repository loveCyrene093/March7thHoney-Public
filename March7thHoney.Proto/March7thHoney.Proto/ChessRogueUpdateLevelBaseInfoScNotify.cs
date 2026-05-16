using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueUpdateLevelBaseInfoScNotify : IMessage<ChessRogueUpdateLevelBaseInfoScNotify>, IMessage, IEquatable<ChessRogueUpdateLevelBaseInfoScNotify>, IDeepCloneable<ChessRogueUpdateLevelBaseInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueUpdateLevelBaseInfoScNotify> _parser = new MessageParser<ChessRogueUpdateLevelBaseInfoScNotify>(() => new ChessRogueUpdateLevelBaseInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ReasonFieldNumber = 5;

	private IDFCGGMMFFA reason_;

	public const int LHJEJEPGKFHFieldNumber = 12;

	private KGDIMPEOGOL lHJEJEPGKFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueUpdateLevelBaseInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueUpdateLevelBaseInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDFCGGMMFFA Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGDIMPEOGOL LHJEJEPGKFH
	{
		get
		{
			return lHJEJEPGKFH_;
		}
		set
		{
			lHJEJEPGKFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateLevelBaseInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateLevelBaseInfoScNotify(ChessRogueUpdateLevelBaseInfoScNotify other)
		: this()
	{
		reason_ = other.reason_;
		lHJEJEPGKFH_ = other.lHJEJEPGKFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateLevelBaseInfoScNotify Clone()
	{
		return new ChessRogueUpdateLevelBaseInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueUpdateLevelBaseInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueUpdateLevelBaseInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (LHJEJEPGKFH != other.LHJEJEPGKFH)
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
		if (Reason != IDFCGGMMFFA.Aplhjfdkecf)
		{
			num ^= Reason.GetHashCode();
		}
		if (LHJEJEPGKFH != KGDIMPEOGOL.Imiigjbmdop)
		{
			num ^= LHJEJEPGKFH.GetHashCode();
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
		if (Reason != IDFCGGMMFFA.Aplhjfdkecf)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Reason);
		}
		if (LHJEJEPGKFH != KGDIMPEOGOL.Imiigjbmdop)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)LHJEJEPGKFH);
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
		if (Reason != IDFCGGMMFFA.Aplhjfdkecf)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (LHJEJEPGKFH != KGDIMPEOGOL.Imiigjbmdop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LHJEJEPGKFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueUpdateLevelBaseInfoScNotify other)
	{
		if (other != null)
		{
			if (other.Reason != IDFCGGMMFFA.Aplhjfdkecf)
			{
				Reason = other.Reason;
			}
			if (other.LHJEJEPGKFH != KGDIMPEOGOL.Imiigjbmdop)
			{
				LHJEJEPGKFH = other.LHJEJEPGKFH;
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
			case 40u:
				Reason = (IDFCGGMMFFA)input.ReadEnum();
				break;
			case 96u:
				LHJEJEPGKFH = (KGDIMPEOGOL)input.ReadEnum();
				break;
			}
		}
	}
}
