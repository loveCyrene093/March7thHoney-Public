using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PunkLordRaidTimeOutScNotify : IMessage<PunkLordRaidTimeOutScNotify>, IMessage, IEquatable<PunkLordRaidTimeOutScNotify>, IDeepCloneable<PunkLordRaidTimeOutScNotify>, IBufferMessage
{
	private static readonly MessageParser<PunkLordRaidTimeOutScNotify> _parser = new MessageParser<PunkLordRaidTimeOutScNotify>(() => new PunkLordRaidTimeOutScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FFCDPHMJJKGFieldNumber = 3;

	private PunkLordMonsterBasicInfo fFCDPHMJJKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PunkLordRaidTimeOutScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PunkLordRaidTimeOutScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterBasicInfo FFCDPHMJJKG
	{
		get
		{
			return fFCDPHMJJKG_;
		}
		set
		{
			fFCDPHMJJKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordRaidTimeOutScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordRaidTimeOutScNotify(PunkLordRaidTimeOutScNotify other)
		: this()
	{
		fFCDPHMJJKG_ = ((other.fFCDPHMJJKG_ != null) ? other.fFCDPHMJJKG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordRaidTimeOutScNotify Clone()
	{
		return new PunkLordRaidTimeOutScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PunkLordRaidTimeOutScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PunkLordRaidTimeOutScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FFCDPHMJJKG, other.FFCDPHMJJKG))
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
		if (fFCDPHMJJKG_ != null)
		{
			num ^= FFCDPHMJJKG.GetHashCode();
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
		if (fFCDPHMJJKG_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(FFCDPHMJJKG);
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
		if (fFCDPHMJJKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFCDPHMJJKG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PunkLordRaidTimeOutScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fFCDPHMJJKG_ != null)
		{
			if (fFCDPHMJJKG_ == null)
			{
				FFCDPHMJJKG = new PunkLordMonsterBasicInfo();
			}
			FFCDPHMJJKG.MergeFrom(other.FFCDPHMJJKG);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (fFCDPHMJJKG_ == null)
			{
				FFCDPHMJJKG = new PunkLordMonsterBasicInfo();
			}
			input.ReadMessage(FFCDPHMJJKG);
		}
	}
}
