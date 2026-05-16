using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LCDOCKJGFCE : IMessage<LCDOCKJGFCE>, IMessage, IEquatable<LCDOCKJGFCE>, IDeepCloneable<LCDOCKJGFCE>, IBufferMessage
{
	private static readonly MessageParser<LCDOCKJGFCE> _parser = new MessageParser<LCDOCKJGFCE>(() => new LCDOCKJGFCE());

	private UnknownFieldSet _unknownFields;

	public const int AGAKLHCAKOLFieldNumber = 10;

	private CPPAAIIHAGI aGAKLHCAKOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LCDOCKJGFCE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LCDOCKJGFCEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPPAAIIHAGI AGAKLHCAKOL
	{
		get
		{
			return aGAKLHCAKOL_;
		}
		set
		{
			aGAKLHCAKOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCDOCKJGFCE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCDOCKJGFCE(LCDOCKJGFCE other)
		: this()
	{
		aGAKLHCAKOL_ = ((other.aGAKLHCAKOL_ != null) ? other.aGAKLHCAKOL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCDOCKJGFCE Clone()
	{
		return new LCDOCKJGFCE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LCDOCKJGFCE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LCDOCKJGFCE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AGAKLHCAKOL, other.AGAKLHCAKOL))
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
		if (aGAKLHCAKOL_ != null)
		{
			num ^= AGAKLHCAKOL.GetHashCode();
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
		if (aGAKLHCAKOL_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(AGAKLHCAKOL);
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
		if (aGAKLHCAKOL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AGAKLHCAKOL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LCDOCKJGFCE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aGAKLHCAKOL_ != null)
		{
			if (aGAKLHCAKOL_ == null)
			{
				AGAKLHCAKOL = new CPPAAIIHAGI();
			}
			AGAKLHCAKOL.MergeFrom(other.AGAKLHCAKOL);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (aGAKLHCAKOL_ == null)
			{
				AGAKLHCAKOL = new CPPAAIIHAGI();
			}
			input.ReadMessage(AGAKLHCAKOL);
		}
	}
}
