using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubmitMaterialSubmitActivityMaterialScRsp : IMessage<SubmitMaterialSubmitActivityMaterialScRsp>, IMessage, IEquatable<SubmitMaterialSubmitActivityMaterialScRsp>, IDeepCloneable<SubmitMaterialSubmitActivityMaterialScRsp>, IBufferMessage
{
	private static readonly MessageParser<SubmitMaterialSubmitActivityMaterialScRsp> _parser = new MessageParser<SubmitMaterialSubmitActivityMaterialScRsp>(() => new SubmitMaterialSubmitActivityMaterialScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int DMMOFCCMKPEFieldNumber = 11;

	private HBPFFKNNLBC dMMOFCCMKPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SubmitMaterialSubmitActivityMaterialScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SubmitMaterialSubmitActivityMaterialScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBPFFKNNLBC DMMOFCCMKPE
	{
		get
		{
			return dMMOFCCMKPE_;
		}
		set
		{
			dMMOFCCMKPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitMaterialSubmitActivityMaterialScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitMaterialSubmitActivityMaterialScRsp(SubmitMaterialSubmitActivityMaterialScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		dMMOFCCMKPE_ = ((other.dMMOFCCMKPE_ != null) ? other.dMMOFCCMKPE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitMaterialSubmitActivityMaterialScRsp Clone()
	{
		return new SubmitMaterialSubmitActivityMaterialScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SubmitMaterialSubmitActivityMaterialScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SubmitMaterialSubmitActivityMaterialScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(DMMOFCCMKPE, other.DMMOFCCMKPE))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (dMMOFCCMKPE_ != null)
		{
			num ^= DMMOFCCMKPE.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (dMMOFCCMKPE_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DMMOFCCMKPE);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (dMMOFCCMKPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DMMOFCCMKPE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubmitMaterialSubmitActivityMaterialScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.dMMOFCCMKPE_ != null)
		{
			if (dMMOFCCMKPE_ == null)
			{
				DMMOFCCMKPE = new HBPFFKNNLBC();
			}
			DMMOFCCMKPE.MergeFrom(other.DMMOFCCMKPE);
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
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (dMMOFCCMKPE_ == null)
				{
					DMMOFCCMKPE = new HBPFFKNNLBC();
				}
				input.ReadMessage(DMMOFCCMKPE);
				break;
			}
		}
	}
}
