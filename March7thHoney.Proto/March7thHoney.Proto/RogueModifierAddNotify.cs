using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueModifierAddNotify : IMessage<RogueModifierAddNotify>, IMessage, IEquatable<RogueModifierAddNotify>, IDeepCloneable<RogueModifierAddNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueModifierAddNotify> _parser = new MessageParser<RogueModifierAddNotify>(() => new RogueModifierAddNotify());

	private UnknownFieldSet _unknownFields;

	public const int IMIBFEHPDDIFieldNumber = 7;

	private DOIJNCLJGKO iMIBFEHPDDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueModifierAddNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueModifierAddNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOIJNCLJGKO IMIBFEHPDDI
	{
		get
		{
			return iMIBFEHPDDI_;
		}
		set
		{
			iMIBFEHPDDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueModifierAddNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueModifierAddNotify(RogueModifierAddNotify other)
		: this()
	{
		iMIBFEHPDDI_ = ((other.iMIBFEHPDDI_ != null) ? other.iMIBFEHPDDI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueModifierAddNotify Clone()
	{
		return new RogueModifierAddNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueModifierAddNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueModifierAddNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IMIBFEHPDDI, other.IMIBFEHPDDI))
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
		if (iMIBFEHPDDI_ != null)
		{
			num ^= IMIBFEHPDDI.GetHashCode();
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
		if (iMIBFEHPDDI_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(IMIBFEHPDDI);
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
		if (iMIBFEHPDDI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMIBFEHPDDI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueModifierAddNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iMIBFEHPDDI_ != null)
		{
			if (iMIBFEHPDDI_ == null)
			{
				IMIBFEHPDDI = new DOIJNCLJGKO();
			}
			IMIBFEHPDDI.MergeFrom(other.IMIBFEHPDDI);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (iMIBFEHPDDI_ == null)
			{
				IMIBFEHPDDI = new DOIJNCLJGKO();
			}
			input.ReadMessage(IMIBFEHPDDI);
		}
	}
}
