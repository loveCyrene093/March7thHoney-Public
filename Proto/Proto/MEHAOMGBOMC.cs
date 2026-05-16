using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MEHAOMGBOMC : IMessage<MEHAOMGBOMC>, IMessage, IEquatable<MEHAOMGBOMC>, IDeepCloneable<MEHAOMGBOMC>, IBufferMessage
{
	private static readonly MessageParser<MEHAOMGBOMC> _parser = new MessageParser<MEHAOMGBOMC>(() => new MEHAOMGBOMC());

	private UnknownFieldSet _unknownFields;

	public const int AFCMOOFGBPKFieldNumber = 509;

	private DLGEGGCHCID aFCMOOFGBPK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MEHAOMGBOMC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MEHAOMGBOMCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLGEGGCHCID AFCMOOFGBPK
	{
		get
		{
			return aFCMOOFGBPK_;
		}
		set
		{
			aFCMOOFGBPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEHAOMGBOMC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEHAOMGBOMC(MEHAOMGBOMC other)
		: this()
	{
		aFCMOOFGBPK_ = ((other.aFCMOOFGBPK_ != null) ? other.aFCMOOFGBPK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEHAOMGBOMC Clone()
	{
		return new MEHAOMGBOMC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MEHAOMGBOMC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MEHAOMGBOMC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AFCMOOFGBPK, other.AFCMOOFGBPK))
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
		if (aFCMOOFGBPK_ != null)
		{
			num ^= AFCMOOFGBPK.GetHashCode();
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
		if (aFCMOOFGBPK_ != null)
		{
			output.WriteRawTag(234, 31);
			output.WriteMessage(AFCMOOFGBPK);
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
		if (aFCMOOFGBPK_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AFCMOOFGBPK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MEHAOMGBOMC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aFCMOOFGBPK_ != null)
		{
			if (aFCMOOFGBPK_ == null)
			{
				AFCMOOFGBPK = new DLGEGGCHCID();
			}
			AFCMOOFGBPK.MergeFrom(other.AFCMOOFGBPK);
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
			if (num != 4074)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (aFCMOOFGBPK_ == null)
			{
				AFCMOOFGBPK = new DLGEGGCHCID();
			}
			input.ReadMessage(AFCMOOFGBPK);
		}
	}
}
