using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MJGHOBOEODL : IMessage<MJGHOBOEODL>, IMessage, IEquatable<MJGHOBOEODL>, IDeepCloneable<MJGHOBOEODL>, IBufferMessage
{
	private static readonly MessageParser<MJGHOBOEODL> _parser = new MessageParser<MJGHOBOEODL>(() => new MJGHOBOEODL());

	private UnknownFieldSet _unknownFields;

	public const int MDGKJEBCKFPFieldNumber = 4;

	private uint mDGKJEBCKFP_;

	public const int LBOBNPOBNEKFieldNumber = 8;

	private uint lBOBNPOBNEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MJGHOBOEODL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MJGHOBOEODLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MDGKJEBCKFP
	{
		get
		{
			return mDGKJEBCKFP_;
		}
		set
		{
			mDGKJEBCKFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LBOBNPOBNEK
	{
		get
		{
			return lBOBNPOBNEK_;
		}
		set
		{
			lBOBNPOBNEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJGHOBOEODL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJGHOBOEODL(MJGHOBOEODL other)
		: this()
	{
		mDGKJEBCKFP_ = other.mDGKJEBCKFP_;
		lBOBNPOBNEK_ = other.lBOBNPOBNEK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJGHOBOEODL Clone()
	{
		return new MJGHOBOEODL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MJGHOBOEODL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MJGHOBOEODL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MDGKJEBCKFP != other.MDGKJEBCKFP)
		{
			return false;
		}
		if (LBOBNPOBNEK != other.LBOBNPOBNEK)
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
		if (MDGKJEBCKFP != 0)
		{
			num ^= MDGKJEBCKFP.GetHashCode();
		}
		if (LBOBNPOBNEK != 0)
		{
			num ^= LBOBNPOBNEK.GetHashCode();
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
		if (MDGKJEBCKFP != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MDGKJEBCKFP);
		}
		if (LBOBNPOBNEK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LBOBNPOBNEK);
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
		if (MDGKJEBCKFP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MDGKJEBCKFP);
		}
		if (LBOBNPOBNEK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LBOBNPOBNEK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MJGHOBOEODL other)
	{
		if (other != null)
		{
			if (other.MDGKJEBCKFP != 0)
			{
				MDGKJEBCKFP = other.MDGKJEBCKFP;
			}
			if (other.LBOBNPOBNEK != 0)
			{
				LBOBNPOBNEK = other.LBOBNPOBNEK;
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
				MDGKJEBCKFP = input.ReadUInt32();
				break;
			case 64u:
				LBOBNPOBNEK = input.ReadUInt32();
				break;
			}
		}
	}
}
