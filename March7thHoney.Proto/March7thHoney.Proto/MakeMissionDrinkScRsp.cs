using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MakeMissionDrinkScRsp : IMessage<MakeMissionDrinkScRsp>, IMessage, IEquatable<MakeMissionDrinkScRsp>, IDeepCloneable<MakeMissionDrinkScRsp>, IBufferMessage
{
	private static readonly MessageParser<MakeMissionDrinkScRsp> _parser = new MessageParser<MakeMissionDrinkScRsp>(() => new MakeMissionDrinkScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IsSaveFieldNumber = 5;

	private bool isSave_;

	public const int DAIKNKALKCMFieldNumber = 7;

	private bool dAIKNKALKCM_;

	public const int DKGODNAMBHHFieldNumber = 11;

	private CIGKBDIGGOI dKGODNAMBHH_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MakeMissionDrinkScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MakeMissionDrinkScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSave
	{
		get
		{
			return isSave_;
		}
		set
		{
			isSave_ = value;
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
	public CIGKBDIGGOI DKGODNAMBHH
	{
		get
		{
			return dKGODNAMBHH_;
		}
		set
		{
			dKGODNAMBHH_ = value;
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
	public MakeMissionDrinkScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeMissionDrinkScRsp(MakeMissionDrinkScRsp other)
		: this()
	{
		isSave_ = other.isSave_;
		dAIKNKALKCM_ = other.dAIKNKALKCM_;
		dKGODNAMBHH_ = ((other.dKGODNAMBHH_ != null) ? other.dKGODNAMBHH_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeMissionDrinkScRsp Clone()
	{
		return new MakeMissionDrinkScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MakeMissionDrinkScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MakeMissionDrinkScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsSave != other.IsSave)
		{
			return false;
		}
		if (DAIKNKALKCM != other.DAIKNKALKCM)
		{
			return false;
		}
		if (!object.Equals(DKGODNAMBHH, other.DKGODNAMBHH))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (IsSave)
		{
			num ^= IsSave.GetHashCode();
		}
		if (DAIKNKALKCM)
		{
			num ^= DAIKNKALKCM.GetHashCode();
		}
		if (dKGODNAMBHH_ != null)
		{
			num ^= DKGODNAMBHH.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (IsSave)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsSave);
		}
		if (DAIKNKALKCM)
		{
			output.WriteRawTag(56);
			output.WriteBool(DAIKNKALKCM);
		}
		if (dKGODNAMBHH_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DKGODNAMBHH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
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
		if (IsSave)
		{
			num += 2;
		}
		if (DAIKNKALKCM)
		{
			num += 2;
		}
		if (dKGODNAMBHH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DKGODNAMBHH);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MakeMissionDrinkScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IsSave)
		{
			IsSave = other.IsSave;
		}
		if (other.DAIKNKALKCM)
		{
			DAIKNKALKCM = other.DAIKNKALKCM;
		}
		if (other.dKGODNAMBHH_ != null)
		{
			if (dKGODNAMBHH_ == null)
			{
				DKGODNAMBHH = new CIGKBDIGGOI();
			}
			DKGODNAMBHH.MergeFrom(other.DKGODNAMBHH);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
				IsSave = input.ReadBool();
				break;
			case 56u:
				DAIKNKALKCM = input.ReadBool();
				break;
			case 90u:
				if (dKGODNAMBHH_ == null)
				{
					DKGODNAMBHH = new CIGKBDIGGOI();
				}
				input.ReadMessage(DKGODNAMBHH);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
