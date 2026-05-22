using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OPNCDHGNEDF : IMessage<OPNCDHGNEDF>, IMessage, IEquatable<OPNCDHGNEDF>, IDeepCloneable<OPNCDHGNEDF>, IBufferMessage
{
	private static readonly MessageParser<OPNCDHGNEDF> _parser = new MessageParser<OPNCDHGNEDF>(() => new OPNCDHGNEDF());

	private UnknownFieldSet _unknownFields;

	public const int PNFBHHBLAFHFieldNumber = 10;

	private uint pNFBHHBLAFH_;

	public const int PONOBJJOADIFieldNumber = 14;

	private uint pONOBJJOADI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OPNCDHGNEDF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OPNCDHGNEDFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNFBHHBLAFH
	{
		get
		{
			return pNFBHHBLAFH_;
		}
		set
		{
			pNFBHHBLAFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PONOBJJOADI
	{
		get
		{
			return pONOBJJOADI_;
		}
		set
		{
			pONOBJJOADI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPNCDHGNEDF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPNCDHGNEDF(OPNCDHGNEDF other)
		: this()
	{
		pNFBHHBLAFH_ = other.pNFBHHBLAFH_;
		pONOBJJOADI_ = other.pONOBJJOADI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPNCDHGNEDF Clone()
	{
		return new OPNCDHGNEDF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OPNCDHGNEDF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OPNCDHGNEDF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PNFBHHBLAFH != other.PNFBHHBLAFH)
		{
			return false;
		}
		if (PONOBJJOADI != other.PONOBJJOADI)
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
		if (PNFBHHBLAFH != 0)
		{
			num ^= PNFBHHBLAFH.GetHashCode();
		}
		if (PONOBJJOADI != 0)
		{
			num ^= PONOBJJOADI.GetHashCode();
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
		if (PNFBHHBLAFH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PNFBHHBLAFH);
		}
		if (PONOBJJOADI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PONOBJJOADI);
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
		if (PNFBHHBLAFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNFBHHBLAFH);
		}
		if (PONOBJJOADI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PONOBJJOADI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OPNCDHGNEDF other)
	{
		if (other != null)
		{
			if (other.PNFBHHBLAFH != 0)
			{
				PNFBHHBLAFH = other.PNFBHHBLAFH;
			}
			if (other.PONOBJJOADI != 0)
			{
				PONOBJJOADI = other.PONOBJJOADI;
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
			case 80u:
				PNFBHHBLAFH = input.ReadUInt32();
				break;
			case 112u:
				PONOBJJOADI = input.ReadUInt32();
				break;
			}
		}
	}
}
