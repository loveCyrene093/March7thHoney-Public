using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PNDOKOLEPLC : IMessage<PNDOKOLEPLC>, IMessage, IEquatable<PNDOKOLEPLC>, IDeepCloneable<PNDOKOLEPLC>, IBufferMessage
{
	private static readonly MessageParser<PNDOKOLEPLC> _parser = new MessageParser<PNDOKOLEPLC>(() => new PNDOKOLEPLC());

	private UnknownFieldSet _unknownFields;

	public const int JCOCKJGKFDKFieldNumber = 4;

	private bool jCOCKJGKFDK_;

	public const int IsTakenRewardFieldNumber = 9;

	private bool isTakenReward_;

	public const int BGBEOFKEJEGFieldNumber = 10;

	private ulong bGBEOFKEJEG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PNDOKOLEPLC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PNDOKOLEPLCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JCOCKJGKFDK
	{
		get
		{
			return jCOCKJGKFDK_;
		}
		set
		{
			jCOCKJGKFDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTakenReward
	{
		get
		{
			return isTakenReward_;
		}
		set
		{
			isTakenReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong BGBEOFKEJEG
	{
		get
		{
			return bGBEOFKEJEG_;
		}
		set
		{
			bGBEOFKEJEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNDOKOLEPLC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNDOKOLEPLC(PNDOKOLEPLC other)
		: this()
	{
		jCOCKJGKFDK_ = other.jCOCKJGKFDK_;
		isTakenReward_ = other.isTakenReward_;
		bGBEOFKEJEG_ = other.bGBEOFKEJEG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNDOKOLEPLC Clone()
	{
		return new PNDOKOLEPLC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PNDOKOLEPLC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PNDOKOLEPLC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JCOCKJGKFDK != other.JCOCKJGKFDK)
		{
			return false;
		}
		if (IsTakenReward != other.IsTakenReward)
		{
			return false;
		}
		if (BGBEOFKEJEG != other.BGBEOFKEJEG)
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
		if (JCOCKJGKFDK)
		{
			num ^= JCOCKJGKFDK.GetHashCode();
		}
		if (IsTakenReward)
		{
			num ^= IsTakenReward.GetHashCode();
		}
		if (BGBEOFKEJEG != 0L)
		{
			num ^= BGBEOFKEJEG.GetHashCode();
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
		if (JCOCKJGKFDK)
		{
			output.WriteRawTag(32);
			output.WriteBool(JCOCKJGKFDK);
		}
		if (IsTakenReward)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsTakenReward);
		}
		if (BGBEOFKEJEG != 0L)
		{
			output.WriteRawTag(80);
			output.WriteUInt64(BGBEOFKEJEG);
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
		if (JCOCKJGKFDK)
		{
			num += 2;
		}
		if (IsTakenReward)
		{
			num += 2;
		}
		if (BGBEOFKEJEG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BGBEOFKEJEG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PNDOKOLEPLC other)
	{
		if (other != null)
		{
			if (other.JCOCKJGKFDK)
			{
				JCOCKJGKFDK = other.JCOCKJGKFDK;
			}
			if (other.IsTakenReward)
			{
				IsTakenReward = other.IsTakenReward;
			}
			if (other.BGBEOFKEJEG != 0L)
			{
				BGBEOFKEJEG = other.BGBEOFKEJEG;
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
			case 32u:
				JCOCKJGKFDK = input.ReadBool();
				break;
			case 72u:
				IsTakenReward = input.ReadBool();
				break;
			case 80u:
				BGBEOFKEJEG = input.ReadUInt64();
				break;
			}
		}
	}
}
