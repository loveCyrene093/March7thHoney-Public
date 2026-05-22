using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DIMKCEBGKKN : IMessage<DIMKCEBGKKN>, IMessage, IEquatable<DIMKCEBGKKN>, IDeepCloneable<DIMKCEBGKKN>, IBufferMessage
{
	private static readonly MessageParser<DIMKCEBGKKN> _parser = new MessageParser<DIMKCEBGKKN>(() => new DIMKCEBGKKN());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 1;

	private ulong uniqueId_;

	public const int BJDIGCMBDPMFieldNumber = 6;

	private GOOBKLOEKFO bJDIGCMBDPM_;

	public const int SourceFieldNumber = 8;

	private MCAFGBPLFEH source_;

	public const int ConfigIdFieldNumber = 10;

	private uint configId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DIMKCEBGKKN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DIMKCEBGKKNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOOBKLOEKFO BJDIGCMBDPM
	{
		get
		{
			return bJDIGCMBDPM_;
		}
		set
		{
			bJDIGCMBDPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCAFGBPLFEH Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIMKCEBGKKN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIMKCEBGKKN(DIMKCEBGKKN other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		bJDIGCMBDPM_ = ((other.bJDIGCMBDPM_ != null) ? other.bJDIGCMBDPM_.Clone() : null);
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		configId_ = other.configId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIMKCEBGKKN Clone()
	{
		return new DIMKCEBGKKN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DIMKCEBGKKN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DIMKCEBGKKN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(BJDIGCMBDPM, other.BJDIGCMBDPM))
		{
			return false;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
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
		if (UniqueId != 0L)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (bJDIGCMBDPM_ != null)
		{
			num ^= BJDIGCMBDPM.GetHashCode();
		}
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
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
		if (UniqueId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(UniqueId);
		}
		if (bJDIGCMBDPM_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BJDIGCMBDPM);
		}
		if (source_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Source);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ConfigId);
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
		if (UniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UniqueId);
		}
		if (bJDIGCMBDPM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BJDIGCMBDPM);
		}
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DIMKCEBGKKN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0L)
		{
			UniqueId = other.UniqueId;
		}
		if (other.bJDIGCMBDPM_ != null)
		{
			if (bJDIGCMBDPM_ == null)
			{
				BJDIGCMBDPM = new GOOBKLOEKFO();
			}
			BJDIGCMBDPM.MergeFrom(other.BJDIGCMBDPM);
		}
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				Source = new MCAFGBPLFEH();
			}
			Source.MergeFrom(other.Source);
		}
		if (other.ConfigId != 0)
		{
			ConfigId = other.ConfigId;
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
			case 8u:
				UniqueId = input.ReadUInt64();
				break;
			case 50u:
				if (bJDIGCMBDPM_ == null)
				{
					BJDIGCMBDPM = new GOOBKLOEKFO();
				}
				input.ReadMessage(BJDIGCMBDPM);
				break;
			case 66u:
				if (source_ == null)
				{
					Source = new MCAFGBPLFEH();
				}
				input.ReadMessage(Source);
				break;
			case 80u:
				ConfigId = input.ReadUInt32();
				break;
			}
		}
	}
}
