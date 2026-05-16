using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightLevelSyncInfo : IMessage<GridFightLevelSyncInfo>, IMessage, IEquatable<GridFightLevelSyncInfo>, IDeepCloneable<GridFightLevelSyncInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightLevelSyncInfo> _parser = new MessageParser<GridFightLevelSyncInfo>(() => new GridFightLevelSyncInfo());

	private UnknownFieldSet _unknownFields;

	public const int SectionIdFieldNumber = 1;

	private uint sectionId_;

	public const int DCPKPNLKGMMFieldNumber = 3;

	private uint dCPKPNLKGMM_;

	public const int GridFightLayerInfoFieldNumber = 8;

	private GridFightLayerInfo gridFightLayerInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightLevelSyncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightLevelSyncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SectionId
	{
		get
		{
			return sectionId_;
		}
		set
		{
			sectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCPKPNLKGMM
	{
		get
		{
			return dCPKPNLKGMM_;
		}
		set
		{
			dCPKPNLKGMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLayerInfo GridFightLayerInfo
	{
		get
		{
			return gridFightLayerInfo_;
		}
		set
		{
			gridFightLayerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLevelSyncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLevelSyncInfo(GridFightLevelSyncInfo other)
		: this()
	{
		sectionId_ = other.sectionId_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		gridFightLayerInfo_ = ((other.gridFightLayerInfo_ != null) ? other.gridFightLayerInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLevelSyncInfo Clone()
	{
		return new GridFightLevelSyncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightLevelSyncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightLevelSyncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		if (!object.Equals(GridFightLayerInfo, other.GridFightLayerInfo))
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
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		if (gridFightLayerInfo_ != null)
		{
			num ^= GridFightLayerInfo.GetHashCode();
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
		if (SectionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(SectionId);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		if (gridFightLayerInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(GridFightLayerInfo);
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
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (gridFightLayerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightLayerInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightLevelSyncInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SectionId != 0)
		{
			SectionId = other.SectionId;
		}
		if (other.DCPKPNLKGMM != 0)
		{
			DCPKPNLKGMM = other.DCPKPNLKGMM;
		}
		if (other.gridFightLayerInfo_ != null)
		{
			if (gridFightLayerInfo_ == null)
			{
				GridFightLayerInfo = new GridFightLayerInfo();
			}
			GridFightLayerInfo.MergeFrom(other.GridFightLayerInfo);
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
				SectionId = input.ReadUInt32();
				break;
			case 24u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			case 66u:
				if (gridFightLayerInfo_ == null)
				{
					GridFightLayerInfo = new GridFightLayerInfo();
				}
				input.ReadMessage(GridFightLayerInfo);
				break;
			}
		}
	}
}
