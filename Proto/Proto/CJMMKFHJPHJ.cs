using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CJMMKFHJPHJ : IMessage<CJMMKFHJPHJ>, IMessage, IEquatable<CJMMKFHJPHJ>, IDeepCloneable<CJMMKFHJPHJ>, IBufferMessage
{
	private static readonly MessageParser<CJMMKFHJPHJ> _parser = new MessageParser<CJMMKFHJPHJ>(() => new CJMMKFHJPHJ());

	private UnknownFieldSet _unknownFields;

	public const int FHJIFGIBDIAFieldNumber = 12;

	private uint fHJIFGIBDIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CJMMKFHJPHJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CJMMKFHJPHJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHJIFGIBDIA
	{
		get
		{
			return fHJIFGIBDIA_;
		}
		set
		{
			fHJIFGIBDIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJMMKFHJPHJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJMMKFHJPHJ(CJMMKFHJPHJ other)
		: this()
	{
		fHJIFGIBDIA_ = other.fHJIFGIBDIA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJMMKFHJPHJ Clone()
	{
		return new CJMMKFHJPHJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CJMMKFHJPHJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CJMMKFHJPHJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FHJIFGIBDIA != other.FHJIFGIBDIA)
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
		if (FHJIFGIBDIA != 0)
		{
			num ^= FHJIFGIBDIA.GetHashCode();
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
		if (FHJIFGIBDIA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(FHJIFGIBDIA);
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
		if (FHJIFGIBDIA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHJIFGIBDIA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CJMMKFHJPHJ other)
	{
		if (other != null)
		{
			if (other.FHJIFGIBDIA != 0)
			{
				FHJIFGIBDIA = other.FHJIFGIBDIA;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				FHJIFGIBDIA = input.ReadUInt32();
			}
		}
	}
}
