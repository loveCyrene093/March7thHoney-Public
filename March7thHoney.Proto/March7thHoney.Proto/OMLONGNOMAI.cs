using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OMLONGNOMAI : IMessage<OMLONGNOMAI>, IMessage, IEquatable<OMLONGNOMAI>, IDeepCloneable<OMLONGNOMAI>, IBufferMessage
{
	private static readonly MessageParser<OMLONGNOMAI> _parser = new MessageParser<OMLONGNOMAI>(() => new OMLONGNOMAI());

	private UnknownFieldSet _unknownFields;

	public const int MKBFHJDMJKLFieldNumber = 4;

	private uint mKBFHJDMJKL_;

	public const int PNJHMGNEJJIFieldNumber = 9;

	private uint pNJHMGNEJJI_;

	public const int NIOAOBGFMEHFieldNumber = 10;

	private uint nIOAOBGFMEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OMLONGNOMAI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OMLONGNOMAIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKBFHJDMJKL
	{
		get
		{
			return mKBFHJDMJKL_;
		}
		set
		{
			mKBFHJDMJKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNJHMGNEJJI
	{
		get
		{
			return pNJHMGNEJJI_;
		}
		set
		{
			pNJHMGNEJJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NIOAOBGFMEH
	{
		get
		{
			return nIOAOBGFMEH_;
		}
		set
		{
			nIOAOBGFMEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMLONGNOMAI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMLONGNOMAI(OMLONGNOMAI other)
		: this()
	{
		mKBFHJDMJKL_ = other.mKBFHJDMJKL_;
		pNJHMGNEJJI_ = other.pNJHMGNEJJI_;
		nIOAOBGFMEH_ = other.nIOAOBGFMEH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMLONGNOMAI Clone()
	{
		return new OMLONGNOMAI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OMLONGNOMAI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OMLONGNOMAI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MKBFHJDMJKL != other.MKBFHJDMJKL)
		{
			return false;
		}
		if (PNJHMGNEJJI != other.PNJHMGNEJJI)
		{
			return false;
		}
		if (NIOAOBGFMEH != other.NIOAOBGFMEH)
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
		if (MKBFHJDMJKL != 0)
		{
			num ^= MKBFHJDMJKL.GetHashCode();
		}
		if (PNJHMGNEJJI != 0)
		{
			num ^= PNJHMGNEJJI.GetHashCode();
		}
		if (NIOAOBGFMEH != 0)
		{
			num ^= NIOAOBGFMEH.GetHashCode();
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
		if (MKBFHJDMJKL != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MKBFHJDMJKL);
		}
		if (PNJHMGNEJJI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PNJHMGNEJJI);
		}
		if (NIOAOBGFMEH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NIOAOBGFMEH);
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
		if (MKBFHJDMJKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKBFHJDMJKL);
		}
		if (PNJHMGNEJJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNJHMGNEJJI);
		}
		if (NIOAOBGFMEH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NIOAOBGFMEH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OMLONGNOMAI other)
	{
		if (other != null)
		{
			if (other.MKBFHJDMJKL != 0)
			{
				MKBFHJDMJKL = other.MKBFHJDMJKL;
			}
			if (other.PNJHMGNEJJI != 0)
			{
				PNJHMGNEJJI = other.PNJHMGNEJJI;
			}
			if (other.NIOAOBGFMEH != 0)
			{
				NIOAOBGFMEH = other.NIOAOBGFMEH;
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
				MKBFHJDMJKL = input.ReadUInt32();
				break;
			case 72u:
				PNJHMGNEJJI = input.ReadUInt32();
				break;
			case 80u:
				NIOAOBGFMEH = input.ReadUInt32();
				break;
			}
		}
	}
}
