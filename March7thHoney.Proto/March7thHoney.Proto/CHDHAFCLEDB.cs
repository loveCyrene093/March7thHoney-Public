using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CHDHAFCLEDB : IMessage<CHDHAFCLEDB>, IMessage, IEquatable<CHDHAFCLEDB>, IDeepCloneable<CHDHAFCLEDB>, IBufferMessage
{
	private static readonly MessageParser<CHDHAFCLEDB> _parser = new MessageParser<CHDHAFCLEDB>(() => new CHDHAFCLEDB());

	private UnknownFieldSet _unknownFields;

	public const int IEGFPJFFCAMFieldNumber = 1;

	private static readonly FieldCodec<JAFPMLLOGDI> _repeated_iEGFPJFFCAM_codec = FieldCodec.ForMessage(10u, JAFPMLLOGDI.Parser);

	private readonly RepeatedField<JAFPMLLOGDI> iEGFPJFFCAM_ = new RepeatedField<JAFPMLLOGDI>();

	public const int MBCNAEAJMDMFieldNumber = 14;

	private uint mBCNAEAJMDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CHDHAFCLEDB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CHDHAFCLEDBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JAFPMLLOGDI> IEGFPJFFCAM => iEGFPJFFCAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBCNAEAJMDM
	{
		get
		{
			return mBCNAEAJMDM_;
		}
		set
		{
			mBCNAEAJMDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHDHAFCLEDB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHDHAFCLEDB(CHDHAFCLEDB other)
		: this()
	{
		iEGFPJFFCAM_ = other.iEGFPJFFCAM_.Clone();
		mBCNAEAJMDM_ = other.mBCNAEAJMDM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHDHAFCLEDB Clone()
	{
		return new CHDHAFCLEDB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CHDHAFCLEDB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CHDHAFCLEDB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iEGFPJFFCAM_.Equals(other.iEGFPJFFCAM_))
		{
			return false;
		}
		if (MBCNAEAJMDM != other.MBCNAEAJMDM)
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
		num ^= iEGFPJFFCAM_.GetHashCode();
		if (MBCNAEAJMDM != 0)
		{
			num ^= MBCNAEAJMDM.GetHashCode();
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
		iEGFPJFFCAM_.WriteTo(ref output, _repeated_iEGFPJFFCAM_codec);
		if (MBCNAEAJMDM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MBCNAEAJMDM);
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
		num += iEGFPJFFCAM_.CalculateSize(_repeated_iEGFPJFFCAM_codec);
		if (MBCNAEAJMDM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBCNAEAJMDM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CHDHAFCLEDB other)
	{
		if (other != null)
		{
			iEGFPJFFCAM_.Add(other.iEGFPJFFCAM_);
			if (other.MBCNAEAJMDM != 0)
			{
				MBCNAEAJMDM = other.MBCNAEAJMDM;
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
			case 10u:
				iEGFPJFFCAM_.AddEntriesFrom(ref input, _repeated_iEGFPJFFCAM_codec);
				break;
			case 112u:
				MBCNAEAJMDM = input.ReadUInt32();
				break;
			}
		}
	}
}
