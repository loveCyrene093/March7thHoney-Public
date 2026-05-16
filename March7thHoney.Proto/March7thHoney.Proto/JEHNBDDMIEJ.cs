using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JEHNBDDMIEJ : IMessage<JEHNBDDMIEJ>, IMessage, IEquatable<JEHNBDDMIEJ>, IDeepCloneable<JEHNBDDMIEJ>, IBufferMessage
{
	private static readonly MessageParser<JEHNBDDMIEJ> _parser = new MessageParser<JEHNBDDMIEJ>(() => new JEHNBDDMIEJ());

	private UnknownFieldSet _unknownFields;

	public const int PABCEJMCHJPFieldNumber = 2;

	private KIPKNECKPHC pABCEJMCHJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JEHNBDDMIEJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JEHNBDDMIEJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIPKNECKPHC PABCEJMCHJP
	{
		get
		{
			return pABCEJMCHJP_;
		}
		set
		{
			pABCEJMCHJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEHNBDDMIEJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEHNBDDMIEJ(JEHNBDDMIEJ other)
		: this()
	{
		pABCEJMCHJP_ = ((other.pABCEJMCHJP_ != null) ? other.pABCEJMCHJP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEHNBDDMIEJ Clone()
	{
		return new JEHNBDDMIEJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JEHNBDDMIEJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JEHNBDDMIEJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PABCEJMCHJP, other.PABCEJMCHJP))
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
		if (pABCEJMCHJP_ != null)
		{
			num ^= PABCEJMCHJP.GetHashCode();
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
		if (pABCEJMCHJP_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PABCEJMCHJP);
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
		if (pABCEJMCHJP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PABCEJMCHJP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JEHNBDDMIEJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pABCEJMCHJP_ != null)
		{
			if (pABCEJMCHJP_ == null)
			{
				PABCEJMCHJP = new KIPKNECKPHC();
			}
			PABCEJMCHJP.MergeFrom(other.PABCEJMCHJP);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pABCEJMCHJP_ == null)
			{
				PABCEJMCHJP = new KIPKNECKPHC();
			}
			input.ReadMessage(PABCEJMCHJP);
		}
	}
}
