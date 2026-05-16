using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ODLKOFOPBIH : IMessage<ODLKOFOPBIH>, IMessage, IEquatable<ODLKOFOPBIH>, IDeepCloneable<ODLKOFOPBIH>, IBufferMessage
{
	private static readonly MessageParser<ODLKOFOPBIH> _parser = new MessageParser<ODLKOFOPBIH>(() => new ODLKOFOPBIH());

	private UnknownFieldSet _unknownFields;

	public const int BGDGGALAODOFieldNumber = 3;

	private JPFIELFEFHD bGDGGALAODO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ODLKOFOPBIH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ODLKOFOPBIHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPFIELFEFHD BGDGGALAODO
	{
		get
		{
			return bGDGGALAODO_;
		}
		set
		{
			bGDGGALAODO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODLKOFOPBIH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODLKOFOPBIH(ODLKOFOPBIH other)
		: this()
	{
		bGDGGALAODO_ = ((other.bGDGGALAODO_ != null) ? other.bGDGGALAODO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODLKOFOPBIH Clone()
	{
		return new ODLKOFOPBIH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ODLKOFOPBIH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ODLKOFOPBIH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BGDGGALAODO, other.BGDGGALAODO))
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
		if (bGDGGALAODO_ != null)
		{
			num ^= BGDGGALAODO.GetHashCode();
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
		if (bGDGGALAODO_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BGDGGALAODO);
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
		if (bGDGGALAODO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGDGGALAODO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ODLKOFOPBIH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bGDGGALAODO_ != null)
		{
			if (bGDGGALAODO_ == null)
			{
				BGDGGALAODO = new JPFIELFEFHD();
			}
			BGDGGALAODO.MergeFrom(other.BGDGGALAODO);
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
			if (bGDGGALAODO_ == null)
			{
				BGDGGALAODO = new JPFIELFEFHD();
			}
			input.ReadMessage(BGDGGALAODO);
		}
	}
}
