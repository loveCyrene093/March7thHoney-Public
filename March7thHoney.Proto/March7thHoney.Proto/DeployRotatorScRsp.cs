using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DeployRotatorScRsp : IMessage<DeployRotatorScRsp>, IMessage, IEquatable<DeployRotatorScRsp>, IDeepCloneable<DeployRotatorScRsp>, IBufferMessage
{
	private static readonly MessageParser<DeployRotatorScRsp> _parser = new MessageParser<DeployRotatorScRsp>(() => new DeployRotatorScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RotaterDataFieldNumber = 3;

	private RotaterData rotaterData_;

	public const int EnergyInfoFieldNumber = 13;

	private RotaterEnergyInfo energyInfo_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DeployRotatorScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DeployRotatorScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterData RotaterData
	{
		get
		{
			return rotaterData_;
		}
		set
		{
			rotaterData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterEnergyInfo EnergyInfo
	{
		get
		{
			return energyInfo_;
		}
		set
		{
			energyInfo_ = value;
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
	public DeployRotatorScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeployRotatorScRsp(DeployRotatorScRsp other)
		: this()
	{
		rotaterData_ = ((other.rotaterData_ != null) ? other.rotaterData_.Clone() : null);
		energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeployRotatorScRsp Clone()
	{
		return new DeployRotatorScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DeployRotatorScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DeployRotatorScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RotaterData, other.RotaterData))
		{
			return false;
		}
		if (!object.Equals(EnergyInfo, other.EnergyInfo))
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
		if (rotaterData_ != null)
		{
			num ^= RotaterData.GetHashCode();
		}
		if (energyInfo_ != null)
		{
			num ^= EnergyInfo.GetHashCode();
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
		if (rotaterData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RotaterData);
		}
		if (energyInfo_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EnergyInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		if (rotaterData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RotaterData);
		}
		if (energyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnergyInfo);
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
	public void MergeFrom(DeployRotatorScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rotaterData_ != null)
		{
			if (rotaterData_ == null)
			{
				RotaterData = new RotaterData();
			}
			RotaterData.MergeFrom(other.RotaterData);
		}
		if (other.energyInfo_ != null)
		{
			if (energyInfo_ == null)
			{
				EnergyInfo = new RotaterEnergyInfo();
			}
			EnergyInfo.MergeFrom(other.EnergyInfo);
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
			case 26u:
				if (rotaterData_ == null)
				{
					RotaterData = new RotaterData();
				}
				input.ReadMessage(RotaterData);
				break;
			case 106u:
				if (energyInfo_ == null)
				{
					EnergyInfo = new RotaterEnergyInfo();
				}
				input.ReadMessage(EnergyInfo);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
