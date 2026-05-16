using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MakeDrinkScRsp : IMessage<MakeDrinkScRsp>, IMessage, IEquatable<MakeDrinkScRsp>, IDeepCloneable<MakeDrinkScRsp>, IBufferMessage
{
	private static readonly MessageParser<MakeDrinkScRsp> _parser = new MessageParser<MakeDrinkScRsp>(() => new MakeDrinkScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LPCLPHICDHGFieldNumber = 5;

	private uint lPCLPHICDHG_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int DAIKNKALKCMFieldNumber = 14;

	private bool dAIKNKALKCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MakeDrinkScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MakeDrinkScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPCLPHICDHG
	{
		get
		{
			return lPCLPHICDHG_;
		}
		set
		{
			lPCLPHICDHG_ = value;
		}
	}

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
	public bool DAIKNKALKCM
	{
		get
		{
			return dAIKNKALKCM_;
		}
		set
		{
			dAIKNKALKCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeDrinkScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeDrinkScRsp(MakeDrinkScRsp other)
		: this()
	{
		lPCLPHICDHG_ = other.lPCLPHICDHG_;
		retcode_ = other.retcode_;
		dAIKNKALKCM_ = other.dAIKNKALKCM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeDrinkScRsp Clone()
	{
		return new MakeDrinkScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MakeDrinkScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MakeDrinkScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LPCLPHICDHG != other.LPCLPHICDHG)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (DAIKNKALKCM != other.DAIKNKALKCM)
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
		if (LPCLPHICDHG != 0)
		{
			num ^= LPCLPHICDHG.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (DAIKNKALKCM)
		{
			num ^= DAIKNKALKCM.GetHashCode();
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
		if (LPCLPHICDHG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LPCLPHICDHG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (DAIKNKALKCM)
		{
			output.WriteRawTag(112);
			output.WriteBool(DAIKNKALKCM);
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
		if (LPCLPHICDHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPCLPHICDHG);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (DAIKNKALKCM)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MakeDrinkScRsp other)
	{
		if (other != null)
		{
			if (other.LPCLPHICDHG != 0)
			{
				LPCLPHICDHG = other.LPCLPHICDHG;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.DAIKNKALKCM)
			{
				DAIKNKALKCM = other.DAIKNKALKCM;
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
			case 40u:
				LPCLPHICDHG = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				DAIKNKALKCM = input.ReadBool();
				break;
			}
		}
	}
}
