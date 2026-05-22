using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DDFAFGMLLFD : IMessage<DDFAFGMLLFD>, IMessage, IEquatable<DDFAFGMLLFD>, IDeepCloneable<DDFAFGMLLFD>, IBufferMessage
{
	private static readonly MessageParser<DDFAFGMLLFD> _parser = new MessageParser<DDFAFGMLLFD>(() => new DDFAFGMLLFD());

	private UnknownFieldSet _unknownFields;

	public const int FKMMLKNJCNOFieldNumber = 2;

	private uint fKMMLKNJCNO_;

	public const int MKNNMKBEPOIFieldNumber = 9;

	private uint mKNNMKBEPOI_;

	public const int APDABNGDMPMFieldNumber = 12;

	private uint aPDABNGDMPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DDFAFGMLLFD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DDFAFGMLLFDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKMMLKNJCNO
	{
		get
		{
			return fKMMLKNJCNO_;
		}
		set
		{
			fKMMLKNJCNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKNNMKBEPOI
	{
		get
		{
			return mKNNMKBEPOI_;
		}
		set
		{
			mKNNMKBEPOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APDABNGDMPM
	{
		get
		{
			return aPDABNGDMPM_;
		}
		set
		{
			aPDABNGDMPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDFAFGMLLFD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDFAFGMLLFD(DDFAFGMLLFD other)
		: this()
	{
		fKMMLKNJCNO_ = other.fKMMLKNJCNO_;
		mKNNMKBEPOI_ = other.mKNNMKBEPOI_;
		aPDABNGDMPM_ = other.aPDABNGDMPM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDFAFGMLLFD Clone()
	{
		return new DDFAFGMLLFD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DDFAFGMLLFD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DDFAFGMLLFD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FKMMLKNJCNO != other.FKMMLKNJCNO)
		{
			return false;
		}
		if (MKNNMKBEPOI != other.MKNNMKBEPOI)
		{
			return false;
		}
		if (APDABNGDMPM != other.APDABNGDMPM)
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
		if (FKMMLKNJCNO != 0)
		{
			num ^= FKMMLKNJCNO.GetHashCode();
		}
		if (MKNNMKBEPOI != 0)
		{
			num ^= MKNNMKBEPOI.GetHashCode();
		}
		if (APDABNGDMPM != 0)
		{
			num ^= APDABNGDMPM.GetHashCode();
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
		if (FKMMLKNJCNO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FKMMLKNJCNO);
		}
		if (MKNNMKBEPOI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(MKNNMKBEPOI);
		}
		if (APDABNGDMPM != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(APDABNGDMPM);
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
		if (FKMMLKNJCNO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKMMLKNJCNO);
		}
		if (MKNNMKBEPOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKNNMKBEPOI);
		}
		if (APDABNGDMPM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APDABNGDMPM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DDFAFGMLLFD other)
	{
		if (other != null)
		{
			if (other.FKMMLKNJCNO != 0)
			{
				FKMMLKNJCNO = other.FKMMLKNJCNO;
			}
			if (other.MKNNMKBEPOI != 0)
			{
				MKNNMKBEPOI = other.MKNNMKBEPOI;
			}
			if (other.APDABNGDMPM != 0)
			{
				APDABNGDMPM = other.APDABNGDMPM;
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
			case 16u:
				FKMMLKNJCNO = input.ReadUInt32();
				break;
			case 72u:
				MKNNMKBEPOI = input.ReadUInt32();
				break;
			case 96u:
				APDABNGDMPM = input.ReadUInt32();
				break;
			}
		}
	}
}
