using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReportPlayerCsReq : IMessage<ReportPlayerCsReq>, IMessage, IEquatable<ReportPlayerCsReq>, IDeepCloneable<ReportPlayerCsReq>, IBufferMessage
{
	private static readonly MessageParser<ReportPlayerCsReq> _parser = new MessageParser<ReportPlayerCsReq>(() => new ReportPlayerCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HELHPDMDLBOFieldNumber = 8;

	private uint hELHPDMDLBO_;

	public const int MPCOLHBJPBPFieldNumber = 11;

	private string mPCOLHBJPBP_ = "";

	public const int UidFieldNumber = 15;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReportPlayerCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ReportPlayerCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HELHPDMDLBO
	{
		get
		{
			return hELHPDMDLBO_;
		}
		set
		{
			hELHPDMDLBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MPCOLHBJPBP
	{
		get
		{
			return mPCOLHBJPBP_;
		}
		set
		{
			mPCOLHBJPBP_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportPlayerCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportPlayerCsReq(ReportPlayerCsReq other)
		: this()
	{
		hELHPDMDLBO_ = other.hELHPDMDLBO_;
		mPCOLHBJPBP_ = other.mPCOLHBJPBP_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportPlayerCsReq Clone()
	{
		return new ReportPlayerCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ReportPlayerCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ReportPlayerCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HELHPDMDLBO != other.HELHPDMDLBO)
		{
			return false;
		}
		if (MPCOLHBJPBP != other.MPCOLHBJPBP)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (HELHPDMDLBO != 0)
		{
			num ^= HELHPDMDLBO.GetHashCode();
		}
		if (MPCOLHBJPBP.Length != 0)
		{
			num ^= MPCOLHBJPBP.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		if (HELHPDMDLBO != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(HELHPDMDLBO);
		}
		if (MPCOLHBJPBP.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(MPCOLHBJPBP);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Uid);
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
		if (HELHPDMDLBO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HELHPDMDLBO);
		}
		if (MPCOLHBJPBP.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MPCOLHBJPBP);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ReportPlayerCsReq other)
	{
		if (other != null)
		{
			if (other.HELHPDMDLBO != 0)
			{
				HELHPDMDLBO = other.HELHPDMDLBO;
			}
			if (other.MPCOLHBJPBP.Length != 0)
			{
				MPCOLHBJPBP = other.MPCOLHBJPBP;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
			case 64u:
				HELHPDMDLBO = input.ReadUInt32();
				break;
			case 90u:
				MPCOLHBJPBP = input.ReadString();
				break;
			case 120u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
