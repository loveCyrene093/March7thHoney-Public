using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DENBKAOHBAM : IMessage<DENBKAOHBAM>, IMessage, IEquatable<DENBKAOHBAM>, IDeepCloneable<DENBKAOHBAM>, IBufferMessage
{
	private static readonly MessageParser<DENBKAOHBAM> _parser = new MessageParser<DENBKAOHBAM>(() => new DENBKAOHBAM());

	private UnknownFieldSet _unknownFields;

	public const int MFOMMFHPJDIFieldNumber = 1;

	private uint mFOMMFHPJDI_;

	public const int DJLCKFKGMDLFieldNumber = 2;

	private double dJLCKFKGMDL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DENBKAOHBAM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DENBKAOHBAMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFOMMFHPJDI
	{
		get
		{
			return mFOMMFHPJDI_;
		}
		set
		{
			mFOMMFHPJDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DJLCKFKGMDL
	{
		get
		{
			return dJLCKFKGMDL_;
		}
		set
		{
			dJLCKFKGMDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DENBKAOHBAM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DENBKAOHBAM(DENBKAOHBAM other)
		: this()
	{
		mFOMMFHPJDI_ = other.mFOMMFHPJDI_;
		dJLCKFKGMDL_ = other.dJLCKFKGMDL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DENBKAOHBAM Clone()
	{
		return new DENBKAOHBAM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DENBKAOHBAM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DENBKAOHBAM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MFOMMFHPJDI != other.MFOMMFHPJDI)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DJLCKFKGMDL, other.DJLCKFKGMDL))
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
		if (MFOMMFHPJDI != 0)
		{
			num ^= MFOMMFHPJDI.GetHashCode();
		}
		if (DJLCKFKGMDL != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DJLCKFKGMDL);
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
		if (MFOMMFHPJDI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MFOMMFHPJDI);
		}
		if (DJLCKFKGMDL != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(DJLCKFKGMDL);
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
		if (MFOMMFHPJDI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFOMMFHPJDI);
		}
		if (DJLCKFKGMDL != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DENBKAOHBAM other)
	{
		if (other != null)
		{
			if (other.MFOMMFHPJDI != 0)
			{
				MFOMMFHPJDI = other.MFOMMFHPJDI;
			}
			if (other.DJLCKFKGMDL != 0.0)
			{
				DJLCKFKGMDL = other.DJLCKFKGMDL;
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
			case 8u:
				MFOMMFHPJDI = input.ReadUInt32();
				break;
			case 17u:
				DJLCKFKGMDL = input.ReadDouble();
				break;
			}
		}
	}
}
