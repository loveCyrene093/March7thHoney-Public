using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGPPBIDINBI : IMessage<OGPPBIDINBI>, IMessage, IEquatable<OGPPBIDINBI>, IDeepCloneable<OGPPBIDINBI>, IBufferMessage
{
	private static readonly MessageParser<OGPPBIDINBI> _parser = new MessageParser<OGPPBIDINBI>(() => new OGPPBIDINBI());

	private UnknownFieldSet _unknownFields;

	public const int OPOGEMADLEIFieldNumber = 9;

	private IFCBCBLFALM oPOGEMADLEI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGPPBIDINBI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGPPBIDINBIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFCBCBLFALM OPOGEMADLEI
	{
		get
		{
			return oPOGEMADLEI_;
		}
		set
		{
			oPOGEMADLEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGPPBIDINBI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGPPBIDINBI(OGPPBIDINBI other)
		: this()
	{
		oPOGEMADLEI_ = ((other.oPOGEMADLEI_ != null) ? other.oPOGEMADLEI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGPPBIDINBI Clone()
	{
		return new OGPPBIDINBI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGPPBIDINBI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGPPBIDINBI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OPOGEMADLEI, other.OPOGEMADLEI))
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
		if (oPOGEMADLEI_ != null)
		{
			num ^= OPOGEMADLEI.GetHashCode();
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
		if (oPOGEMADLEI_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(OPOGEMADLEI);
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
		if (oPOGEMADLEI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OPOGEMADLEI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OGPPBIDINBI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oPOGEMADLEI_ != null)
		{
			if (oPOGEMADLEI_ == null)
			{
				OPOGEMADLEI = new IFCBCBLFALM();
			}
			OPOGEMADLEI.MergeFrom(other.OPOGEMADLEI);
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
			if (oPOGEMADLEI_ == null)
			{
				OPOGEMADLEI = new IFCBCBLFALM();
			}
			input.ReadMessage(OPOGEMADLEI);
		}
	}
}
