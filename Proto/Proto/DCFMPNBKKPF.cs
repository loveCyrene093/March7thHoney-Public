using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DCFMPNBKKPF : IMessage<DCFMPNBKKPF>, IMessage, IEquatable<DCFMPNBKKPF>, IDeepCloneable<DCFMPNBKKPF>, IBufferMessage
{
	private static readonly MessageParser<DCFMPNBKKPF> _parser = new MessageParser<DCFMPNBKKPF>(() => new DCFMPNBKKPF());

	private UnknownFieldSet _unknownFields;

	public const int GLBPFJGJFEEFieldNumber = 1;

	private NAGEJMIGBBL gLBPFJGJFEE_;

	public const int BFPGBLAIKHFFieldNumber = 2;

	private CCKLMNCPGFO bFPGBLAIKHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DCFMPNBKKPF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DCFMPNBKKPFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAGEJMIGBBL GLBPFJGJFEE
	{
		get
		{
			return gLBPFJGJFEE_;
		}
		set
		{
			gLBPFJGJFEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKLMNCPGFO BFPGBLAIKHF
	{
		get
		{
			return bFPGBLAIKHF_;
		}
		set
		{
			bFPGBLAIKHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCFMPNBKKPF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCFMPNBKKPF(DCFMPNBKKPF other)
		: this()
	{
		gLBPFJGJFEE_ = ((other.gLBPFJGJFEE_ != null) ? other.gLBPFJGJFEE_.Clone() : null);
		bFPGBLAIKHF_ = ((other.bFPGBLAIKHF_ != null) ? other.bFPGBLAIKHF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCFMPNBKKPF Clone()
	{
		return new DCFMPNBKKPF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DCFMPNBKKPF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DCFMPNBKKPF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GLBPFJGJFEE, other.GLBPFJGJFEE))
		{
			return false;
		}
		if (!object.Equals(BFPGBLAIKHF, other.BFPGBLAIKHF))
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
		if (gLBPFJGJFEE_ != null)
		{
			num ^= GLBPFJGJFEE.GetHashCode();
		}
		if (bFPGBLAIKHF_ != null)
		{
			num ^= BFPGBLAIKHF.GetHashCode();
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
		if (gLBPFJGJFEE_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GLBPFJGJFEE);
		}
		if (bFPGBLAIKHF_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BFPGBLAIKHF);
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
		if (gLBPFJGJFEE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GLBPFJGJFEE);
		}
		if (bFPGBLAIKHF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BFPGBLAIKHF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DCFMPNBKKPF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gLBPFJGJFEE_ != null)
		{
			if (gLBPFJGJFEE_ == null)
			{
				GLBPFJGJFEE = new NAGEJMIGBBL();
			}
			GLBPFJGJFEE.MergeFrom(other.GLBPFJGJFEE);
		}
		if (other.bFPGBLAIKHF_ != null)
		{
			if (bFPGBLAIKHF_ == null)
			{
				BFPGBLAIKHF = new CCKLMNCPGFO();
			}
			BFPGBLAIKHF.MergeFrom(other.BFPGBLAIKHF);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				if (gLBPFJGJFEE_ == null)
				{
					GLBPFJGJFEE = new NAGEJMIGBBL();
				}
				input.ReadMessage(GLBPFJGJFEE);
				break;
			case 18u:
				if (bFPGBLAIKHF_ == null)
				{
					BFPGBLAIKHF = new CCKLMNCPGFO();
				}
				input.ReadMessage(BFPGBLAIKHF);
				break;
			}
		}
	}
}
