using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HJMLNLKCOJJ : IMessage<HJMLNLKCOJJ>, IMessage, IEquatable<HJMLNLKCOJJ>, IDeepCloneable<HJMLNLKCOJJ>, IBufferMessage
{
	private static readonly MessageParser<HJMLNLKCOJJ> _parser = new MessageParser<HJMLNLKCOJJ>(() => new HJMLNLKCOJJ());

	private UnknownFieldSet _unknownFields;

	public const int FANCADKJJCEFieldNumber = 9;

	private BDEMABPLPKO fANCADKJJCE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HJMLNLKCOJJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HJMLNLKCOJJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEMABPLPKO FANCADKJJCE
	{
		get
		{
			return fANCADKJJCE_;
		}
		set
		{
			fANCADKJJCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJMLNLKCOJJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJMLNLKCOJJ(HJMLNLKCOJJ other)
		: this()
	{
		fANCADKJJCE_ = ((other.fANCADKJJCE_ != null) ? other.fANCADKJJCE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJMLNLKCOJJ Clone()
	{
		return new HJMLNLKCOJJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HJMLNLKCOJJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HJMLNLKCOJJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FANCADKJJCE, other.FANCADKJJCE))
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
		if (fANCADKJJCE_ != null)
		{
			num ^= FANCADKJJCE.GetHashCode();
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
		if (fANCADKJJCE_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(FANCADKJJCE);
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
		if (fANCADKJJCE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FANCADKJJCE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HJMLNLKCOJJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fANCADKJJCE_ != null)
		{
			if (fANCADKJJCE_ == null)
			{
				FANCADKJJCE = new BDEMABPLPKO();
			}
			FANCADKJJCE.MergeFrom(other.FANCADKJJCE);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (fANCADKJJCE_ == null)
			{
				FANCADKJJCE = new BDEMABPLPKO();
			}
			input.ReadMessage(FANCADKJJCE);
		}
	}
}
